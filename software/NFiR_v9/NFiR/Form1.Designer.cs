using System.Linq;

namespace NFiR {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comGroupBox = new System.Windows.Forms.GroupBox();
            this.processButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rxConsoleRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rxTextFileRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txConsoleRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txTextFileRadioButton = new System.Windows.Forms.RadioButton();
            this.rxTextBox = new System.Windows.Forms.TextBox();
            this.txTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txButton = new System.Windows.Forms.Button();
            this.errorCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.asciiCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.comComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txConsoleGroupBox = new System.Windows.Forms.GroupBox();
            this.txConsoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rxConsoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.rxConsoleGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.txConsoleGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.rxConsoleGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comGroupBox
            // 
            this.comGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comGroupBox.Controls.Add(this.processButton);
            this.comGroupBox.Controls.Add(this.browseButton);
            this.comGroupBox.Controls.Add(this.panel2);
            this.comGroupBox.Controls.Add(this.panel1);
            this.comGroupBox.Controls.Add(this.rxTextBox);
            this.comGroupBox.Controls.Add(this.txTextBox);
            this.comGroupBox.Controls.Add(this.label8);
            this.comGroupBox.Controls.Add(this.label6);
            this.comGroupBox.Controls.Add(this.txButton);
            this.comGroupBox.Controls.Add(this.errorCountLabel);
            this.comGroupBox.Controls.Add(this.label9);
            this.comGroupBox.Controls.Add(this.asciiCountLabel);
            this.comGroupBox.Controls.Add(this.label7);
            this.comGroupBox.Controls.Add(this.countLabel);
            this.comGroupBox.Controls.Add(this.label3);
            this.comGroupBox.Controls.Add(this.connectLabel);
            this.comGroupBox.Controls.Add(this.closeButton);
            this.comGroupBox.Controls.Add(this.openButton);
            this.comGroupBox.Controls.Add(this.comComboBox);
            this.comGroupBox.Controls.Add(this.label1);
            this.comGroupBox.Location = new System.Drawing.Point(39, 22);
            this.comGroupBox.Name = "comGroupBox";
            this.comGroupBox.Size = new System.Drawing.Size(455, 151);
            this.comGroupBox.TabIndex = 0;
            this.comGroupBox.TabStop = false;
            this.comGroupBox.Text = "Communication";
            // 
            // processButton
            // 
            this.processButton.Enabled = false;
            this.processButton.Location = new System.Drawing.Point(382, 72);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(60, 23);
            this.processButton.TabIndex = 31;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(354, 46);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(24, 23);
            this.browseButton.TabIndex = 30;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rxConsoleRadioButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rxTextFileRadioButton);
            this.panel2.Location = new System.Drawing.Point(27, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 21);
            this.panel2.TabIndex = 29;
            // 
            // rxConsoleRadioButton
            // 
            this.rxConsoleRadioButton.AutoSize = true;
            this.rxConsoleRadioButton.Checked = true;
            this.rxConsoleRadioButton.Location = new System.Drawing.Point(107, 0);
            this.rxConsoleRadioButton.Name = "rxConsoleRadioButton";
            this.rxConsoleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.rxConsoleRadioButton.TabIndex = 2;
            this.rxConsoleRadioButton.TabStop = true;
            this.rxConsoleRadioButton.Text = "Console";
            this.rxConsoleRadioButton.UseVisualStyleBackColor = true;
            this.rxConsoleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rx Output";
            // 
            // rxTextFileRadioButton
            // 
            this.rxTextFileRadioButton.AutoSize = true;
            this.rxTextFileRadioButton.Location = new System.Drawing.Point(60, 0);
            this.rxTextFileRadioButton.Name = "rxTextFileRadioButton";
            this.rxTextFileRadioButton.Size = new System.Drawing.Size(41, 17);
            this.rxTextFileRadioButton.TabIndex = 1;
            this.rxTextFileRadioButton.Text = "File";
            this.rxTextFileRadioButton.UseVisualStyleBackColor = true;
            this.rxTextFileRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txConsoleRadioButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txTextFileRadioButton);
            this.panel1.Location = new System.Drawing.Point(27, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 18);
            this.panel1.TabIndex = 28;
            // 
            // txConsoleRadioButton
            // 
            this.txConsoleRadioButton.AutoSize = true;
            this.txConsoleRadioButton.Checked = true;
            this.txConsoleRadioButton.Location = new System.Drawing.Point(107, -2);
            this.txConsoleRadioButton.Name = "txConsoleRadioButton";
            this.txConsoleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.txConsoleRadioButton.TabIndex = 2;
            this.txConsoleRadioButton.TabStop = true;
            this.txConsoleRadioButton.Text = "Console";
            this.txConsoleRadioButton.UseVisualStyleBackColor = true;
            this.txConsoleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tx Input";
            // 
            // txTextFileRadioButton
            // 
            this.txTextFileRadioButton.AutoSize = true;
            this.txTextFileRadioButton.Location = new System.Drawing.Point(60, -2);
            this.txTextFileRadioButton.Name = "txTextFileRadioButton";
            this.txTextFileRadioButton.Size = new System.Drawing.Size(41, 17);
            this.txTextFileRadioButton.TabIndex = 1;
            this.txTextFileRadioButton.Text = "File";
            this.txTextFileRadioButton.UseVisualStyleBackColor = true;
            this.txTextFileRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rxTextBox
            // 
            this.rxTextBox.Enabled = false;
            this.rxTextBox.Location = new System.Drawing.Point(103, 70);
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.Size = new System.Drawing.Size(245, 20);
            this.rxTextBox.TabIndex = 27;
            this.rxTextBox.Text = "NFiR_Rx.txt";
            // 
            // txTextBox
            // 
            this.txTextBox.Enabled = false;
            this.txTextBox.Location = new System.Drawing.Point(103, 48);
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.Size = new System.Drawing.Size(245, 20);
            this.txTextBox.TabIndex = 26;
            this.txTextBox.Text = "NFiR_Tx.txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Rx Input File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tx Output File";
            // 
            // txButton
            // 
            this.txButton.Enabled = false;
            this.txButton.Location = new System.Drawing.Point(382, 46);
            this.txButton.Name = "txButton";
            this.txButton.Size = new System.Drawing.Size(60, 23);
            this.txButton.TabIndex = 22;
            this.txButton.Text = "Transmit";
            this.txButton.UseVisualStyleBackColor = true;
            this.txButton.Click += new System.EventHandler(this.txButton_Click);
            // 
            // errorCountLabel
            // 
            this.errorCountLabel.AutoSize = true;
            this.errorCountLabel.Location = new System.Drawing.Point(421, 98);
            this.errorCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorCountLabel.Name = "errorCountLabel";
            this.errorCountLabel.Size = new System.Drawing.Size(13, 13);
            this.errorCountLabel.TabIndex = 21;
            this.errorCountLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ErrorCount";
            // 
            // asciiCountLabel
            // 
            this.asciiCountLabel.AutoSize = true;
            this.asciiCountLabel.Location = new System.Drawing.Point(314, 98);
            this.asciiCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.asciiCountLabel.Name = "asciiCountLabel";
            this.asciiCountLabel.Size = new System.Drawing.Size(13, 13);
            this.asciiCountLabel.TabIndex = 19;
            this.asciiCountLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ASCIICount";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(421, 116);
            this.countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(13, 13);
            this.countLabel.TabIndex = 17;
            this.countLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "RxTotalCount";
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.BackColor = System.Drawing.Color.Red;
            this.connectLabel.Location = new System.Drawing.Point(300, 21);
            this.connectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(10, 13);
            this.connectLabel.TabIndex = 15;
            this.connectLabel.Text = " ";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(382, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 23);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(315, 16);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 23);
            this.openButton.TabIndex = 13;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // comComboBox
            // 
            this.comComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comComboBox.FormattingEnabled = true;
            this.comComboBox.Location = new System.Drawing.Point(83, 18);
            this.comComboBox.Name = "comComboBox";
            this.comComboBox.Size = new System.Drawing.Size(201, 21);
            this.comComboBox.TabIndex = 10;
            this.comComboBox.SelectedIndexChanged += new System.EventHandler(this.comComboBox_SelectedIndexChanged);
            this.comComboBox.Click += new System.EventHandler(this.comComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // txConsoleGroupBox
            // 
            this.txConsoleGroupBox.Controls.Add(this.txConsoleRichTextBox);
            this.txConsoleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txConsoleGroupBox.Location = new System.Drawing.Point(3, 3);
            this.txConsoleGroupBox.Name = "txConsoleGroupBox";
            this.txConsoleGroupBox.Size = new System.Drawing.Size(261, 346);
            this.txConsoleGroupBox.TabIndex = 1;
            this.txConsoleGroupBox.TabStop = false;
            this.txConsoleGroupBox.Text = "Tx Console";
            // 
            // txConsoleRichTextBox
            // 
            this.txConsoleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txConsoleRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.txConsoleRichTextBox.Name = "txConsoleRichTextBox";
            this.txConsoleRichTextBox.Size = new System.Drawing.Size(255, 327);
            this.txConsoleRichTextBox.TabIndex = 0;
            this.txConsoleRichTextBox.Text = "";
            this.txConsoleRichTextBox.TextChanged += new System.EventHandler(this.txConsoleRichTextBox_TextChanged);
            this.txConsoleRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txConsoleRichTextBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.aboutToolStripMenuItem2});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "User Guide";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // rxConsoleRichTextBox
            // 
            this.rxConsoleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxConsoleRichTextBox.Location = new System.Drawing.Point(2, 15);
            this.rxConsoleRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rxConsoleRichTextBox.Name = "rxConsoleRichTextBox";
            this.rxConsoleRichTextBox.Size = new System.Drawing.Size(254, 331);
            this.rxConsoleRichTextBox.TabIndex = 1;
            this.rxConsoleRichTextBox.Text = "";
            this.rxConsoleRichTextBox.TextChanged += new System.EventHandler(this.rxConsoleRichTextBox_TextChanged);
            // 
            // rxConsoleGroupBox
            // 
            this.rxConsoleGroupBox.Controls.Add(this.rxConsoleRichTextBox);
            this.rxConsoleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxConsoleGroupBox.Location = new System.Drawing.Point(269, 2);
            this.rxConsoleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.rxConsoleGroupBox.Name = "rxConsoleGroupBox";
            this.rxConsoleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.rxConsoleGroupBox.Size = new System.Drawing.Size(258, 348);
            this.rxConsoleGroupBox.TabIndex = 3;
            this.rxConsoleGroupBox.TabStop = false;
            this.rxConsoleGroupBox.Text = "Rx Console ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.Controls.Add(this.txConsoleGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rxConsoleGroupBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 198);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 352);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comGroupBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50725F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.49275F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 552);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 460800;
            this.serialPort1.ReadTimeout = 12;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceivedHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 576);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NFiR Transceiver Interface";
            this.comGroupBox.ResumeLayout(false);
            this.comGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.txConsoleGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rxConsoleGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Collections.Generic.Dictionary<string, string> BuildPortNameHash(string[] portsToMap) {
            System.Collections.Generic.Dictionary<string, string> oReturnTable = new System.Collections.Generic.Dictionary<string, string>();
            MineRegistryForPortName("SYSTEM\\CurrentControlSet\\Enum", oReturnTable, portsToMap);
            return oReturnTable;
        }

        private void MineRegistryForPortName(string startKeyPath, System.Collections.Generic.Dictionary<string, string> targetMap,
                                                string[] portsToMap) {
            if (targetMap.Count >= portsToMap.Length)
                return;
            using (Microsoft.Win32.RegistryKey currentKey = Microsoft.Win32.Registry.LocalMachine) {
                try {
                    using (Microsoft.Win32.RegistryKey currentSubKey = currentKey.OpenSubKey(startKeyPath)) {
                        string[] currentSubkeys = currentSubKey.GetSubKeyNames();
                        if (currentSubkeys.Contains("Device Parameters") &&
                            startKeyPath != "SYSTEM\\CurrentControlSet\\Enum") {
                            object portName = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\" +
                                startKeyPath + "\\Device Parameters", "PortName", null);
                            if (portName == null ||
                                portsToMap.Contains(portName.ToString()) == false)
                                return;
                            object friendlyPortName = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\" +
                                startKeyPath, "FriendlyName", null);
                            string friendlyName = "N/A";
                            if (friendlyPortName != null)
                                friendlyName = friendlyPortName.ToString();
                            if (friendlyName.Contains(portName.ToString()) == false)
                                friendlyName = string.Format("{0} ({1})", friendlyName, portName);
                            targetMap[portName.ToString()] = friendlyName;
                        } else {
                            foreach (string strSubKey in currentSubkeys)
                                MineRegistryForPortName(startKeyPath + "\\" + strSubKey, targetMap, portsToMap);
                        }
                    }
                } catch (System.Exception) {
                    //System.Console.WriteLine("Error accessing key '{0}'.. Skipping..", startKeyPath);
                }
            }
        }

        #endregion

        //private System.Text.Encoding projEncoding = System.Text.Encoding.GetEncoding(65000);//28591 //65001 //1252//437
        //private System.Text.Encoding serialEncoding = System.Text.Encoding.GetEncoding(65001);//28591 //65001 //1252//437
        private System.Text.Encoding projEncoding = System.Text.Encoding.GetEncoding(1252);//28591 //65001 //1252//437//ASCII//Unicode//UTF8//UTF7
        private System.Text.Encoding serialEncoding = System.Text.Encoding.GetEncoding(1252);//28591 //65001 //1252//437


        private System.Collections.Generic.LinkedList<char> charLList = new System.Collections.Generic.LinkedList<char>();
        private string txText;

        private System.Text.StringBuilder rxTextFile = new System.Text.StringBuilder();
        private bool textChangedBusy = false;
        private string last_timestamp;
        private int globalCount = 0;
        private int asciiCount = 0;
        private int errorCount = 0;
        private int prevtxTextLength = 0;
        private int prevrxTextLength = 0;
        private System.Text.StringBuilder current_timestamp = new System.Text.StringBuilder();
        private const int baud_rate = 2000000;//460800 2000000
        private System.Windows.Forms.GroupBox comGroupBox;
        private System.Windows.Forms.ComboBox comComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox txConsoleGroupBox;
        private System.Windows.Forms.RichTextBox txConsoleRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.RichTextBox rxConsoleRichTextBox;
        private System.Windows.Forms.GroupBox rxConsoleGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label errorCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label asciiCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txButton;
        private System.Windows.Forms.TextBox txTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rxConsoleRadioButton;
        private System.Windows.Forms.RadioButton rxTextFileRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton txConsoleRadioButton;
        private System.Windows.Forms.RadioButton txTextFileRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rxTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browseButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button processButton;
    }
}

