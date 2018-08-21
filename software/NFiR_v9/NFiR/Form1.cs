using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace NFiR {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            //try {
            //    string[] ports = new string[SerialPort.GetPortNames().Length];
            //    Dictionary<string, string> friendlyPorts = BuildPortNameHash(SerialPort.GetPortNames());
            //    Font dropDownFont = comComboBox.Font;
            //    Graphics g = comComboBox.CreateGraphics();
            //    int newDropDownWidth = 0;
            //    int dropDownWidth = comComboBox.DropDownWidth;
            //    int i = 0;
            //    foreach (KeyValuePair<string, string> kvp in friendlyPorts) {
            //        ports[i] = " " + kvp.Value;
            //        newDropDownWidth = (int)g.MeasureString(kvp.Value, dropDownFont).Width;
            //        i++;
            //        if (dropDownWidth < newDropDownWidth)
            //            dropDownWidth = newDropDownWidth;
            //    }
            //    comComboBox.DropDownWidth = dropDownWidth;
            //    comComboBox.DataSource = ports;
            //    comComboBox.SelectedIndex = 0;
            //    serialPort1.BaudRate = baud_rate;
            //    serialPort1.Encoding = System.Text.Encoding.GetEncoding(28591);
            //} catch (Exception ex) {
            //    Console.WriteLine("Serial Port not detected!");
            //}
            /**** Initialize file format combox with default ****/
            try {
                string[] ports = SerialPort.GetPortNames();
                Dictionary<string, string> friendlyPorts = BuildPortNameHash(SerialPort.GetPortNames());
                Font dropDownFont = comComboBox.Font;
                Graphics g = comComboBox.CreateGraphics();
                int newDropDownWidth = 0;
                int dropDownWidth = comComboBox.DropDownWidth;
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in friendlyPorts) {
                    ports[i] = " " + kvp.Value;
                    newDropDownWidth = (int)g.MeasureString(kvp.Value, dropDownFont).Width;
                    i++;
                    if (dropDownWidth < newDropDownWidth)
                        dropDownWidth = newDropDownWidth;
                }
                comComboBox.DropDownWidth = dropDownWidth;
                ports[0] = "Select a port";
                comComboBox.DataSource = ports;
                comComboBox.SelectedIndex = 0;
            } catch (Exception e) { }

            serialPort1.Encoding = serialEncoding;
            serialPort1.BaudRate = baud_rate;
            //serialPort1.ReceivedBytesThreshold = 2720;
            //Console.WriteLine(serialPort1.ReadBufferSize);
            //Console.WriteLine(serialPort1.ReadTimeout);
            //Console.WriteLine(serialPort1.ReceivedBytesThreshold);
            //Console.WriteLine(serialPort1.BreakState);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
            
            TextDialog.ShowDialog("1. Connect usb cable to PC Board (drivers will install on first plug in) \n"
                                    + "2. Find USB to serial COM port number using Windows Device Manager.\n"
                                    + "3. Click the COM Port drop down menu and select the port from the list.\n"
                                    + "4. Set the the desired settings using radio buttons.\n"
                                    + "5. Type in the transmit console or browse for file to transmit.\n\n"
                                    + "The MIT License (MIT)\n"

+ "Copyright(c) 2018 Virtual Builds\n"

+ "Permission is hereby granted, free of charge, to any person obtaining a copy\n"
+ "of this software and associated documentation files(the \"Software\"), to deal\n"
+ "in the Software without restriction, including without limitation the rights\n"
+ "to use, copy, modify, merge, publish, distribute, sublicense, and / or sell\n"
+ "copies of the Software, and to permit persons to whom the Software is\n"
+ "furnished to do so, subject to the following conditions:\n\n"

+ "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\n"
+ "IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\n"
+ "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE\n"
+ "AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\n"
+ "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\n"
+ "OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN\n"
+ "THE SOFTWARE.\n\n", "User Guide");
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e) {
            TextDialog.ShowDialog("\u00a9 2018 Virtual Builds\n"
                                        + "All Rights Reserved", "About");
        }

        private void serial_Write(string text) {
            if (comComboBox.Text == "Select a port")                             // check com port is chosen
            {
                MessageBox.Show("Please choose COM port", "System Configure Information",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
                if(!String.IsNullOrEmpty(text))
                    serialPort1.Write(text);
            } catch (Exception ex) //UnauthorizedAccessException
              {
                MessageBox.Show("Error: Serial Port Communication \nOriginal error: " + ex.Message,
                                "System Configure Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                return;
            }
        }

        private void serial_Char(char letter) {
            if (comComboBox.Text == "Select a port")                             // check com port is chosen
            {
                MessageBox.Show("Please choose COM port", "System Configure Information",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
                serialPort1.Write(letter.ToString());
                //serialPort1.Write(Convert.ToByte(letter).ToString());
            } catch (Exception ex) //UnauthorizedAccessException
              {
                MessageBox.Show("Error: Serial Port Communication \nOriginal error: " + ex.Message,
                                "System Configure Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                return;
            }
        }

        private void dataReceivedHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
            if (rxConsoleRadioButton.Checked) {
                string rxConsoleText = serialPort1.ReadExisting();
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { rxConsoleText });
            } else if (rxTextFileRadioButton.Checked) {
                rxTextFile.Append(serialPort1.ReadExisting());
            }
            

            //string rxDataString = serialPort1.ReadExisting();
            //this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { rxDataString });
        }

        private delegate void SetTextDeleg(string text);

        private void si_DataReceived(string text) {
            //File.WriteAllText(fileName, text);
            //Console.WriteLine(text);

            StringBuilder fileData = new StringBuilder();
            //List<char> fileData = new List<char>();
            string dummy_timestamp = string.Empty;
            string dummy_timestamp2 = string.Empty;
            string dummy_timestamp3 = string.Empty;
            string timestamp1 = string.Empty, timestamp2 = string.Empty;
            string currportst;
            UInt32 timestampi1 = 0, timestampi2 = 0;
            bool convert = false, charConvertStart = false;
            int charCount = 0;
            uint dataIn = 0;
            
            try {
                foreach (char c in text) {
                    //charQueue.Enqueue(c);
                    charLList.AddLast(c);
                }
                //string temp = File.ReadAllText(fileName);
                //foreach(char c in temp) {
                //    charLList.AddLast(c );
                //}

                while (charLList.Count > 16) { // We are guaranteed a timestamp
                    current_timestamp.Clear();
                    while (!charLList.First().Equals('\n')) {
                        current_timestamp.Append(charLList.First());
                        charLList.RemoveFirst();
                    }
                    charLList.RemoveFirst();
                    if (current_timestamp.Length == 16) {
                        
                        currportst = current_timestamp.ToString().Substring(6, 2);
                        if (currportst == "FF") { //ENV high
                            timestamp1 = current_timestamp.ToString().Substring(8, 8);
                            timestampi1 = Convert.ToUInt32(timestamp1, 16);
                            dummy_timestamp = current_timestamp.ToString();
                        } else { //ENV low
                            timestamp2 = current_timestamp.ToString().Substring(8, 8);
                            timestampi2 = Convert.ToUInt32(timestamp2, 16);
                            convert = true;
                        }
                        if (convert) {
                            UInt32 diff = 0;
                            
                            if (timestampi1 > timestampi2) { // takes care of roll over 
                                diff = (timestampi2 - 0) + (UInt32.MaxValue - timestampi1);
                            } else {
                                diff = (timestampi2 - timestampi1);
                            }
                            //Console.WriteLine("diff " + diff);
                            if (diff > 160 && diff <= 327) {
                                if (charCount == 0) {
                                    charConvertStart = true;
                                } else if (charCount == 8) {
                                    charConvertStart = false;
                                    //Console.WriteLine("print: " + ((char)(dataIn & 0xFF)));
                                    if (rxConsoleRadioButton.Checked) {
                                        rxConsoleRichTextBox.Text += (char)(dataIn & 0xFF);
                                    } else if (rxTextFileRadioButton.Checked) {
                                        fileData.Append((char)(dataIn & 0xFF));
                                    }
                                    charCount = 0;
                                    asciiCount++;
                                    globalCount++;
                                } else {
                                    Console.WriteLine("diff " + diff);
                                    Console.WriteLine("charCount " + charCount );
                                    if (rxConsoleRadioButton.Checked) {
                                        rxConsoleRichTextBox.Text += '*';
                                    } else if (rxTextFileRadioButton.Checked) {
                                        fileData.Append('*');
                                    }
                                    errorCount++;
                                    globalCount++;
                                }
                                //Console.WriteLine();
                            } else if (diff > 327 && diff <= 615) {
                                dataIn = (dataIn << 1);
                                charCount++;
                                //Console.Write("0");
                            } else if (diff > 615 && diff <= 1100) {
                                dataIn = ((dataIn << 1) | 1);
                                charCount++;
                                //Console.Write("1");
                            } else {
                                Console.WriteLine("length diff " + diff);
                                //Console.WriteLine("timeStampi1 " + timestampi1);
                                //Console.WriteLine("timestamp1 " + timestamp1);
                                //Console.WriteLine("timestamp1 length " + timestamp1.Length);
                                //Console.WriteLine("current_timestamp " + current_timestamp.ToString());
                                //Console.WriteLine("current_timestamp length " + current_timestamp.Length);
                                //Console.WriteLine("dummy_timestamp " + dummy_timestamp);
                                //Console.WriteLine("dummy_timestamp length " + dummy_timestamp.Length);
                                //Console.WriteLine("dummy_timestamp2 " + dummy_timestamp2);
                                //Console.WriteLine("dummy_timestamp2 length " + dummy_timestamp2.Length);
                                //Console.WriteLine("dummy_timestamp3 " + dummy_timestamp3);
                                //Console.WriteLine("dummy_timestamp3 length " + dummy_timestamp3.Length);
                                //Console.WriteLine("timestampi2 " + timestampi2);
                                //Console.WriteLine("UInt32.MaxValue " + UInt32.MaxValue);
                            }
                            //Console.WriteLine("print: " + (dataIn));
                            convert = false;
                            //rxConsoleRichTextBox.Text += diff + "\r\n";
                        }

                    }//if timestamp == 16
                    last_timestamp = current_timestamp.ToString();
                    dummy_timestamp2 = current_timestamp.ToString();
                    dummy_timestamp3 = dummy_timestamp2;
                }
                countLabel.Text = globalCount.ToString();
                errorCountLabel.Text = errorCount.ToString();
                asciiCountLabel.Text = asciiCount.ToString();
                if (rxTextFileRadioButton.Checked) {
                    string temp = fileData.ToString();
                    byte[] bytes = new byte[temp.Length];
                    for (int i = 0; i < temp.Length; i++) {
                        bytes[i] = (byte)temp[i];
                    }

                    File.AppendAllText(rxTextBox.Text, System.Text.Encoding.GetEncoding(1252).GetString(bytes), projEncoding);//new string(chars), projEncoding);
                }
            } catch (Exception e) {
                //// do nothing for now 
            }
        }


        private void comComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            serialPort1.Close();
            serialPort1.Dispose();
            string[] split = (comComboBox.Text).Split('(', ')');
            string temp = "";
            if (split.Length > 1) {
                temp = split[split.Length - 2];
                serialPort1.PortName = temp;
            }
        }

        private void openButton_Click(object sender, EventArgs e) {
            if (comComboBox.Text == "Select a port")                             // check com port is chosen
            {
                MessageBox.Show("Please choose COM port", "System Configure Information",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            } else {
                try {
                    if (!serialPort1.IsOpen)
                        serialPort1.Open();
                    connectLabel.BackColor = System.Drawing.Color.Green;
                } catch (Exception ex) //UnauthorizedAccessException
                  {
                    MessageBox.Show("Error: Serial Port Communication \nOriginal error: " + ex.Message,
                                    "System Configure Information",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                    if (serialPort1.IsOpen)
                        serialPort1.Close();
                    connectLabel.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            serialPort1.Close();
        }

        private void txConsoleRichTextBox_TextChanged(object sender, EventArgs e) {

            while (textChangedBusy);
            textChangedBusy = true;
            System.Threading.Thread.Sleep(40);
            int currenttxTextLength =  txConsoleRichTextBox.Text.Length;

            if (prevtxTextLength < currenttxTextLength)
                txText = txConsoleRichTextBox.Text.Substring(prevtxTextLength);
            else
                txText = string.Empty;

            int count = 1;
            string temp = string.Empty;
            foreach (char c in txText) {
                //serial_Char(c);
                temp += c;
                if (count % 4 == 0) {
                    serial_Write(temp);
                    temp = string.Empty;
                    System.Threading.Thread.Sleep(120);
                }
                count++;
            }
            //if (count % 4 != 0) {
                serial_Write(temp);
            //}
            prevtxTextLength = currenttxTextLength;
            textChangedBusy = false;
        }

        private void rxConsoleRichTextBox_TextChanged(object sender, EventArgs e) {
            int currentrxTextLength = rxConsoleRichTextBox.Text.Length;
            string text;
            if (prevrxTextLength < currentrxTextLength)
                text = rxConsoleRichTextBox.Text.Substring(prevrxTextLength);
            else
                text = string.Empty;
            if (text.Contains("\n")) {
                rxConsoleRichTextBox.SelectionStart = rxConsoleRichTextBox.Text.Length;
                // scroll it automatically
                rxConsoleRichTextBox.ScrollToCaret();
            }
            prevrxTextLength = currentrxTextLength;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            txConsoleRichTextBox.Clear();
            rxConsoleRichTextBox.Clear();
            rxTextFile.Clear();
            globalCount = 0;
            countLabel.Text = "0";
            errorCount = 0;
            errorCountLabel.Text = "0";
            asciiCount = 0;
            asciiCountLabel.Text = "0";
            prevtxTextLength = 0;
        }

        private void txButton_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                string text = File.ReadAllText(txTextBox.Text, projEncoding);
                //byte[] bytes = Encoding.Default.GetBytes(File.ReadAllText(txTextBox.Text, projEncoding));
                //string myString = Encoding.UTF8.GetString(bytes);
                int count = 1;
                StringBuilder temp = new StringBuilder();
                    foreach (char c in text) {
                    //serial_Char(c);
                        //if (c == 0)
                        //    temp.Append('\0');
                        //else
                            temp.Append(c);
                        if (count % 4 == 0) {
                            serial_Write(temp.ToString());
                            temp.Clear();
                            System.Threading.Thread.Sleep(20);
                        }
                        count++;
                    }
                //if (count % 4 != 0) {
                    serial_Write(temp.ToString());
                //}
            } catch (Exception exp) {
                System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(exp, true);
                MessageBox.Show("Error: File I/O fault \nOriginal error: " + exp.Message + "\n" + exp.ToString(),
                                "System Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            Cursor.Current = Cursors.Default;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Name) {
                case "txTextFileRadioButton":
                    txTextBox.Enabled = true;
                    txButton.Enabled = true;
                    txConsoleRichTextBox.Enabled = false;
                    break;
                case "txConsoleRadioButton":
                    txTextBox.Enabled = false;
                    txButton.Enabled = false;
                    txConsoleRichTextBox.Enabled = true;
                    break;
                case "rxTextFileRadioButton":
                    rxTextBox.Enabled = true;
                    rxConsoleRichTextBox.Enabled = false;
                    processButton.Enabled = true;
                    break;
                case "rxConsoleRadioButton":
                    rxTextBox.Enabled = false;
                    rxConsoleRichTextBox.Enabled = true;
                    processButton.Enabled = false;
                    break;
            }


        }

        private void browseButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "Text File (.txt)|*.txt|JPEG|*.JPG;*.JPEG*.jpg;*.jpeg";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txTextBox.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e) {
            serial_Char((char) 0x00);
        }

        private void comComboBox_Click(object sender, EventArgs e) {
            string[] ports = SerialPort.GetPortNames();
            Dictionary<string, string> friendlyPorts = BuildPortNameHash(SerialPort.GetPortNames());
            Font dropDownFont = comComboBox.Font;
            Graphics g = comComboBox.CreateGraphics();
            int newDropDownWidth = 0;
            int dropDownWidth = comComboBox.DropDownWidth;
            int i = 0;
            foreach (KeyValuePair<string, string> kvp in friendlyPorts) {
                ports[i] = " " + kvp.Value;
                newDropDownWidth = (int)g.MeasureString(kvp.Value, dropDownFont).Width;
                i++;
                if (dropDownWidth < newDropDownWidth)
                    dropDownWidth = newDropDownWidth;
            }
            comComboBox.DropDownWidth = dropDownWidth;
            comComboBox.DataSource = ports;
        }

        private void txConsoleRichTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            //if (e.KeyChar == (char)13) {
            //    int count = 1;
            //    string temp = string.Empty;
            //    foreach (char c in text) {
            //        //serial_Char(c);
            //        temp += c;
            //        if (count % 4 == 0) {
            //            serial_Write(temp);
            //            temp = string.Empty;
            //            System.Threading.Thread.Sleep(80);
            //        }
            //        count++;
            //    }
            //    if (count % 4 != 0) {
            //        serial_Write(temp);
            //    }
            //    System.Threading.Thread.Sleep(80);
            //    serial_Write("\n");
            //    text = string.Empty;
            //}
        }

        private void processButton_Click(object sender, EventArgs e) {
            StringBuilder fileData = new StringBuilder();
            //List<char> fileData = new List<char>();
            string dummy_timestamp = string.Empty;
            string dummy_timestamp2 = string.Empty;
            string dummy_timestamp3 = string.Empty;
            string timestamp1 = string.Empty, timestamp2 = string.Empty;
            string currportst;
            UInt32 timestampi1 = 0, timestampi2 = 0;
            bool convert = false, charConvertStart = false;
            int charCount = 0;
            uint dataIn = 0;

            string text = rxTextFile.ToString();

            try {
                foreach (char c in text) {
                    //charQueue.Enqueue(c);
                    charLList.AddLast(c);
                }
                //string temp = File.ReadAllText(fileName);
                //foreach(char c in temp) {
                //    charLList.AddLast(c );
                //}

                while (charLList.Count > 16) { // We are guaranteed a timestamp
                    current_timestamp.Clear();
                    while (!charLList.First().Equals('\n')) {
                        current_timestamp.Append(charLList.First());
                        charLList.RemoveFirst();
                    }
                    charLList.RemoveFirst();
                    if (current_timestamp.Length == 16) {

                        currportst = current_timestamp.ToString().Substring(6, 2);
                        if (currportst == "FF") { //ENV high
                            timestamp1 = current_timestamp.ToString().Substring(8, 8);
                            timestampi1 = Convert.ToUInt32(timestamp1, 16);
                            dummy_timestamp = current_timestamp.ToString();
                        } else { //ENV low
                            timestamp2 = current_timestamp.ToString().Substring(8, 8);
                            timestampi2 = Convert.ToUInt32(timestamp2, 16);
                            convert = true;
                        }
                        if (convert) {
                            UInt32 diff = 0;

                            if (timestampi1 > timestampi2) { // takes care of roll over 
                                diff = (timestampi2 - 0) + (UInt32.MaxValue - timestampi1);
                            } else {
                                diff = (timestampi2 - timestampi1);
                            }
                            //Console.WriteLine("diff " + diff);
                            //rxConsoleRichTextBox.Text += diff;
                            if (diff > 160 && diff <= 327) {
                                if (charCount == 0) {
                                    charConvertStart = true;
                                } else if (charCount == 8) {
                                    charConvertStart = false;
                                    //Console.WriteLine("print: " + ((char)(dataIn & 0xFF)));
                                    if (rxConsoleRadioButton.Checked) {
                                        rxConsoleRichTextBox.Text += (char)(dataIn & 0xFF);
                                    } else if (rxTextFileRadioButton.Checked) {
                                        fileData.Append((char)(dataIn & 0xFF));
                                    }
                                    charCount = 0;
                                    asciiCount++;
                                    globalCount++;
                                } else {
                                    Console.WriteLine("diff " + diff);
                                    Console.WriteLine("charCount " + charCount);
                                    if (rxConsoleRadioButton.Checked) {
                                        rxConsoleRichTextBox.Text += '*';
                                        
                                    } else if (rxTextFileRadioButton.Checked) {
                                        fileData.Append('*');
                                    }
                                    errorCount++;
                                    globalCount++;
                                }
                                //Console.WriteLine();
                            } else if (diff > 327 && diff <= 615) {
                                dataIn = (dataIn << 1);
                                charCount++;
                                //Console.Write("0");
                            } else if (diff > 615 && diff <= 1100) {
                                dataIn = ((dataIn << 1) | 1);
                                charCount++;
                                //Console.Write("1");
                            } else {
                                Console.WriteLine("length diff " + diff);
                                //Console.WriteLine("timeStampi1 " + timestampi1);
                                //Console.WriteLine("timestamp1 " + timestamp1);
                                //Console.WriteLine("timestamp1 length " + timestamp1.Length);
                                //Console.WriteLine("current_timestamp " + current_timestamp.ToString());
                                //Console.WriteLine("current_timestamp length " + current_timestamp.Length);
                                //Console.WriteLine("dummy_timestamp " + dummy_timestamp);
                                //Console.WriteLine("dummy_timestamp length " + dummy_timestamp.Length);
                                //Console.WriteLine("dummy_timestamp2 " + dummy_timestamp2);
                                //Console.WriteLine("dummy_timestamp2 length " + dummy_timestamp2.Length);
                                //Console.WriteLine("dummy_timestamp3 " + dummy_timestamp3);
                                //Console.WriteLine("dummy_timestamp3 length " + dummy_timestamp3.Length);
                                //Console.WriteLine("timestampi2 " + timestampi2);
                                //Console.WriteLine("UInt32.MaxValue " + UInt32.MaxValue);
                            }
                            //Console.WriteLine("print: " + (dataIn));
                            convert = false;
                            //rxConsoleRichTextBox.Text += diff.ToString();
                        }

                    }//if timestamp == 16
                    last_timestamp = current_timestamp.ToString();
                    dummy_timestamp2 = current_timestamp.ToString();
                    dummy_timestamp3 = dummy_timestamp2;
                }
                countLabel.Text = globalCount.ToString();
                errorCountLabel.Text = errorCount.ToString();
                asciiCountLabel.Text = asciiCount.ToString();
                if (rxTextFileRadioButton.Checked) {
                    string temp = fileData.ToString();
                    byte[] bytes = new byte[temp.Length];
                    for (int i = 0; i < temp.Length; i++) {
                        bytes[i] = (byte)temp[i];
                    }

                    File.AppendAllText(rxTextBox.Text, System.Text.Encoding.GetEncoding(1252).GetString(bytes), projEncoding);//new string(chars), projEncoding);
                }
            } catch (Exception ex) {
                //// do nothing for now 
            }
        }


    }
}