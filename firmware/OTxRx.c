#include <stdio.h>
#include <stdlib.h>
#include <xc.h>
#include <sys/attribs.h> //interrupts
#include <plib.h>
#include "OTxRx.h"
#include <proc/p32mx170f256d.h>

unsigned char urx1;
unsigned char int1_flag=0;
unsigned char int2_flag=0;
unsigned char sync=0;
unsigned char dump=0;
unsigned int spi_data1;
int i;
unsigned int dumptime;

unsigned int int1_timestamp;
unsigned int int2_timestamp;
unsigned int portb_state;

unsigned char write_addr=0;
unsigned char dump_addr=0;

unsigned int time_stamp[256];
char port_state[256];

void init_sys(void);
void configure_CNC(void);
void configure_timers(void);
void configure_spi(void);
void configure_uart(void);
char uart_getc(void);
void uart_putc(unsigned char);
void uart_puts(char*);
unsigned int read_spi32(unsigned int);
void ascii_print(char);
void timer_print(unsigned int);
void portb_print(unsigned int);
void ascii_ootrx(unsigned char);
unsigned int spi_transfer(unsigned int);

int main(int argc, char** argv) {
    init_sys();
    uart_puts("NFR Tracking: \n\r");
    uart_puts(">");
    write_addr = 0;
    dump_addr = 0;
    PORTBCLR = 0xFF00;
    while(1) {
        //while(!U1STAbits.URXDA);
        if (dump_addr != write_addr) {
            portb_print(port_state[dump_addr]);
            timer_print(time_stamp[dump_addr]);
            uart_puts("\n");
            dump_addr++;
        } else if (U1STAbits.URXDA) {
            urx1 = U1RXREG;
            //uart_putc(urx1);
            ascii_ootrx(urx1);
        }
    }
    return (EXIT_SUCCESS);
}

void __ISR(_CHANGE_NOTICE_VECTOR, IPL4AUTO) CNCInterrupt(void) { 
    time_stamp[write_addr] = TMR4;
    port_state[write_addr] = PORTB; //PORTC
    write_addr++;
    IFS1CLR = 0x00004000;
}

void init_sys(void) {
    TRISA = 0x0000; //RA1=MISO1
    TRISB = 0x00FF; //RB2=U1RX
    TRISC = 0x0040; //all inputs
    ANSELA = 0; ODCA = 0;//All pins to digital
    ANSELB = 0; ODCB = 0;
    ANSELC = 0; ODCC = 0;
    __builtin_disable_interrupts();
    configure_timers();
    configure_uart();
    configure_CNC();
    configure_spi();
    INTCONSET = _INTCON_MVEC_MASK;
    __builtin_enable_interrupts();
}

void configure_CNC(void){  //10,11
    IEC1CLR = 0x00004000;
//    IEC1bits.CNCIE = 0;
    CNCONBbits.ON = 1;  // Change on
//    CNENC = 0x03FF;     // Enable CN0-CN9
//    CNPDC = 0x03FF;
    CNENB = 0x00FF;
    PORTB;
    CNSTATB;
    IPC8SET = 0x00100000;  // Priority 4
    //IPC8SET = 0x001C0000;  // Priority 7
    IEC1SET = 0x00004000; // Enable CN interrupts
    IFS1CLR = 0x00004000; // Reset CN interrupt
//    IPC8bits.CNIP = 7;  // Priority
//    IEC1bits.CNCIE = 1; // Enable CN interrupts
//    IFS1bits.CNCIF = 0; // Reset CN interrupt
}

void configure_timers(void){
    T2CON = 0x0; // Stop any 16/32-bit Timer4 operation
    T3CON = 0x0; // Stop any 16-bit Timer5 operation
    T2CONSET = 0x0008; // Enable 32-bit mode, prescaler 1:1
    TMR2 = 0; // Clear contents of the TMR4 and TMR5
    PR2 = 0xFFFFFFFF; // Load PR4 and PR5 registers with 32-bit value
    //T2CONSET = 0x8000; // Start Timer4/5
    
    OC2CON = 0x00;
    OC3CON = 0x00;
    OC2CONSET = 0x0002; 
    OC2R = 0;
    OC2CONSET = 0x8000;
    IFS0bits.OC2IF = 0;
    IEC0bits.OC2IE = 1; //enable interrupt
    IPC1bits.OC1IP = 7;
    
    T4CON = 0x0; // Stop any 16/32-bit Timer4 operation
    T5CON = 0x0; // Stop any 16-bit Timer5 operation
    T4CONSET = 0x0008; // Enable 32-bit mode, prescaler 1:1
    TMR4 = 0x0; // Clear contents of the TMR4 and TMR5
    PR4 = 0xFFFFFFFF; // Load PR4 and PR5 registers with 32-bit value
    T4CONSET = 0x8000; // Start Timer4/5
}

void configure_uart(void){
    U1BRG = (SYS_FREQ/BAUD/4) - 1;     //PBCLK/BAUD/4 - 1

    U1MODEbits.BRGH = 1;
    U1MODEbits.PDSEL = 0b00;  // no parity
    U1MODEbits.STSEL =  0; // 1 stopbit
    U1MODEbits.UEN = 0b00;
    U1MODEbits.IREN = 0;
    U1MODEbits.SIDL = 0;
    U1MODEbits.RTSMD = 0;
    U1MODEbits.WAKE = 1;
    U1MODEbits.LPBACK = 0;
    U1MODEbits.RXINV = 0;
	U1MODEbits.ON = 1;
 
    U1STAbits.UTXINV = 0;
    U1STAbits.UTXEN = 1;
    U1STAbits.URXEN = 1;
    
    RPC7Rbits.RPC7R = 1; //U1TX
    U1RXRbits.U1RXR = 5; //RPC6
    
    //IFS1CLR = 0x00000380;
	//IPC8SET = 0x0000000C; // U1 interrupt priority 3
    //IEC1SET = 0x00000180; // U1RXIE & U1EIE enable
    
    int i;
    for(i=0;i<400000;i++){};
}

void configure_spi(void){
    RPB15Rbits.RPB15R = 3; //CS1
    RPB13Rbits.RPB13R = 3; //MOSI1
    SDI1Rbits.SDI1R = 0;   //MISO1 = RA1
    //SpiChnOpen(1, SPICON_ON |  SPICON_MODE16 | SPICON_MSTEN, 8); //
    SpiChnOpen(1, SPICON_ON | SPICON_MSTEN, 24);
    SPI1CONbits.CKE = 1;
    SPI1CONbits.CKP = 0;
    CS1 = 0;
}

unsigned int read_spi32(unsigned int i) {
//    CS1 = 0;
    SPI1BUF = i;
    while(!SPI1STATbits.SPIRBF); 
//    CS1 = 1;
    return SPI1BUF;
}

void ascii_print(char hex) {
    switch(hex) {
        case 0x0 : uart_putc('0'); break;
        case 0x1 : uart_putc('1'); break;
        case 0x2 : uart_putc('2'); break;
        case 0x3 : uart_putc('3'); break;
        case 0x4 : uart_putc('4'); break;
        case 0x5 : uart_putc('5'); break;
        case 0x6 : uart_putc('6'); break;
        case 0x7 : uart_putc('7'); break;
        case 0x8 : uart_putc('8'); break;
        case 0x9 : uart_putc('9'); break;
        case 0xA : uart_putc('A'); break;
        case 0xB : uart_putc('B'); break;
        case 0xC : uart_putc('C'); break;
        case 0xD : uart_putc('D'); break;
        case 0xE : uart_putc('E'); break;
        case 0xF : uart_putc('F'); break;
    }
}

void timer_print(unsigned int tmr_data) {
//    uart_puts("Timer: 0x");
    for (i = 28; i >= 0; i-=4) {
        ascii_print(tmr_data >> i & 0x0F);
    }
//    uart_puts("\n\r");
}

void portb_print(unsigned int pb_data) {
//    uart_puts("PORTB: 0x");
    for (i = 28; i >= 0; i-=4) { //i=12 for half port
        ascii_print(pb_data >> i & 0x0F);
    }
//    uart_puts("\n\r");
}

void uart_puts(char *str) {
    int i = 0;
    while(str[i]!='\0'){
        uart_putc(str[i]);
        i++;
    }
}

char uart_getc(void) {
    while(!U1STAbits.URXDA);             // Wait for information to be received
    return U1RXREG;                      // Return received character
}

void uart_putc(unsigned char tx_byte) {
    while(U1STAbits.UTXBF);    // wait while UTXBF == 1.
    U1TXREG = tx_byte;    // Copy byte2send to the UxTXREG register
}

unsigned int spi_transfer(unsigned int sdata) {
    //CS1 = 0;
    SPI1BUF = (sdata << 8) | sdata;
    while(!SPI1STATbits.SPIRBF); 
    //CS1 = 1;
    return SPI1BUF;
}

void ascii_ootrx(unsigned char value) {
    //char j;
    int j = 0, i = 0;
    //SpiChnOpen(1, SPICON_ON | SPICON_MSTEN, 24);
    SPI1CONCLR = 0x00000C00;
    spi_transfer(urx1);
    for(i=0; i<128; i++);
    for(j=0; j<8; j++){
        value = (value << 1) | (value >> 7);
        if (value % 2) {
            //SpiChnOpen(1, SPICON_ON |  SPICON_MODE32 | SPICON_MSTEN, 24); //start stop
            SPI1CONbits.MODE32 = 1;
            SPI1CONbits.MODE16 = 0;
            spi_transfer(urx1);
        } else {
            //SpiChnOpen(1, SPICON_ON |  SPICON_MODE16 | SPICON_MSTEN, 24); //start stop
            SPI1CONbits.MODE32 = 0;
            SPI1CONbits.MODE16 = 1;
            spi_transfer(urx1);
        }
        for(i=0; i<128; i++);
    }
    SPI1CONCLR = 0x00000C00;
    //SpiChnOpen(1, SPICON_ON | SPICON_MSTEN, 24);
    spi_transfer(urx1);
    for(i=0; i<128; i++);
}

