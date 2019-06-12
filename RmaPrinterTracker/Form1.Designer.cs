using System.Windows.Forms;

namespace RmaPrinterTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.neuralabelReplacement_Printer = new System.Windows.Forms.DataGridView();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialnumber_Text = new System.Windows.Forms.TextBox();
            this.serialnumber_CBox = new System.Windows.Forms.ComboBox();
            this.company_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printertype_CBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rma_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.addprinter_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.refresh_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neuralabelReplacement_Printer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 170);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1458, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.neuralabelReplacement_Printer);
            this.tabPage1.Controls.Add(this.connectionStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1450, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Neuralabel - Replacement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // neuralabelReplacement_Printer
            // 
            this.neuralabelReplacement_Printer.AllowUserToAddRows = false;
            this.neuralabelReplacement_Printer.AllowUserToDeleteRows = false;
            this.neuralabelReplacement_Printer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.neuralabelReplacement_Printer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.neuralabelReplacement_Printer.DefaultCellStyle = dataGridViewCellStyle1;
            this.neuralabelReplacement_Printer.Location = new System.Drawing.Point(8, 6);
            this.neuralabelReplacement_Printer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.neuralabelReplacement_Printer.MultiSelect = false;
            this.neuralabelReplacement_Printer.Name = "neuralabelReplacement_Printer";
            this.neuralabelReplacement_Printer.ReadOnly = true;
            this.neuralabelReplacement_Printer.RowHeadersWidth = 51;
            this.neuralabelReplacement_Printer.RowTemplate.Height = 24;
            this.neuralabelReplacement_Printer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.neuralabelReplacement_Printer.Size = new System.Drawing.Size(1434, 394);
            this.neuralabelReplacement_Printer.TabIndex = 0;
            this.neuralabelReplacement_Printer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RowColor);
            this.neuralabelReplacement_Printer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_MouseRightClick);
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.Location = new System.Drawing.Point(1299, 403);
            this.connectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.connectionStatus.Size = new System.Drawing.Size(0, 17);
            this.connectionStatus.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1450, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Neuralabel - RMA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1450, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NeuraLog - Replacement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Size = new System.Drawing.Size(1450, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NeuraLog - RMA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(557, 9);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(383, 46);
            this.title.TabIndex = 3;
            this.title.Text = "Printer RMA Tracker";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialnumber_Text);
            this.groupBox1.Controls.Add(this.serialnumber_CBox);
            this.groupBox1.Controls.Add(this.company_Text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.printertype_CBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rma_Text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(621, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by:";
            // 
            // serialnumber_Text
            // 
            this.serialnumber_Text.Location = new System.Drawing.Point(358, 51);
            this.serialnumber_Text.Margin = new System.Windows.Forms.Padding(4);
            this.serialnumber_Text.Name = "serialnumber_Text";
            this.serialnumber_Text.Size = new System.Drawing.Size(251, 22);
            this.serialnumber_Text.TabIndex = 9;
            this.serialnumber_Text.TextChanged += new System.EventHandler(this.Serialnumber_Text_TextChanged);
            // 
            // serialnumber_CBox
            // 
            this.serialnumber_CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialnumber_CBox.FormattingEnabled = true;
            this.serialnumber_CBox.Items.AddRange(new object[] {
            "Faulty SN",
            "Replacement SN"});
            this.serialnumber_CBox.Location = new System.Drawing.Point(240, 51);
            this.serialnumber_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.serialnumber_CBox.Name = "serialnumber_CBox";
            this.serialnumber_CBox.Size = new System.Drawing.Size(110, 24);
            this.serialnumber_CBox.TabIndex = 1;
            // 
            // company_Text
            // 
            this.company_Text.Location = new System.Drawing.Point(298, 23);
            this.company_Text.Margin = new System.Windows.Forms.Padding(4);
            this.company_Text.Name = "company_Text";
            this.company_Text.Size = new System.Drawing.Size(311, 22);
            this.company_Text.TabIndex = 8;
            this.company_Text.TextChanged += new System.EventHandler(this.Company_Text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Company Name:";
            // 
            // printertype_CBox
            // 
            this.printertype_CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printertype_CBox.FormattingEnabled = true;
            this.printertype_CBox.Items.AddRange(new object[] {
            "Standard",
            "Straight-Through",
            "C-Path"});
            this.printertype_CBox.Location = new System.Drawing.Point(86, 51);
            this.printertype_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.printertype_CBox.Name = "printertype_CBox";
            this.printertype_CBox.Size = new System.Drawing.Size(146, 24);
            this.printertype_CBox.TabIndex = 6;
            this.printertype_CBox.SelectedIndexChanged += new System.EventHandler(this.Printertype_CBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Printer Type:";
            // 
            // rma_Text
            // 
            this.rma_Text.Location = new System.Drawing.Point(86, 23);
            this.rma_Text.Margin = new System.Windows.Forms.Padding(4);
            this.rma_Text.Name = "rma_Text";
            this.rma_Text.Size = new System.Drawing.Size(111, 22);
            this.rma_Text.TabIndex = 5;
            this.rma_Text.TextChanged += new System.EventHandler(this.Rma_Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rma Number";
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(645, 134);
            this.clear_Button.Margin = new System.Windows.Forms.Padding(4);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(53, 29);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // addprinter_Button
            // 
            this.addprinter_Button.Location = new System.Drawing.Point(1362, 626);
            this.addprinter_Button.Name = "addprinter_Button";
            this.addprinter_Button.Size = new System.Drawing.Size(108, 33);
            this.addprinter_Button.TabIndex = 6;
            this.addprinter_Button.Text = "Add Printer";
            this.addprinter_Button.UseVisualStyleBackColor = true;
            this.addprinter_Button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 55);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.MaximumSize = new System.Drawing.Size(65, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 51);
            this.label5.TabIndex = 0;
            this.label5.Text = "Outstanding RMA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(70, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 55);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.MaximumSize = new System.Drawing.Size(90, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Closed/Recieved RMA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(166, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 55);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loaner";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(225, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 55);
            this.panel4.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Upgrade";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleGreen;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(284, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 55);
            this.panel5.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 14);
            this.label8.MaximumSize = new System.Drawing.Size(60, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Possible Sale";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(343, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 55);
            this.panel6.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Swap";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.HotPink;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(404, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(63, 55);
            this.panel7.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sale";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(464, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(63, 55);
            this.panel8.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Demo Unit";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Location = new System.Drawing.Point(888, 79);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(531, 63);
            this.panel9.TabIndex = 9;
            // 
            // refresh_Button
            // 
            this.refresh_Button.Location = new System.Drawing.Point(1264, 629);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.Size = new System.Drawing.Size(75, 23);
            this.refresh_Button.TabIndex = 10;
            this.refresh_Button.Text = "Refresh";
            this.refresh_Button.UseVisualStyleBackColor = true;
            this.refresh_Button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1491, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh_Button);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.addprinter_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Printer Tracker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neuralabelReplacement_Printer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.DataGridView neuralabelReplacement_Printer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label title;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private ComboBox printertype_CBox;
        private Label label2;
        private TextBox rma_Text;
        private ComboBox serialnumber_CBox;
        private TextBox company_Text;
        private TextBox serialnumber_Text;
        private Button clear_Button;
        private Button addprinter_Button;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel9;
        private Button refresh_Button;
        private Button button1;
    }
}

