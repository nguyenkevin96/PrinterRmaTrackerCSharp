namespace RmaPrinterTracker
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.issue_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.return_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.closed_CBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customer_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.faulty_Text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.replacement_Text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.printer_CBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.printername_Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.type_Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.variant_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.notes_TextA = new System.Windows.Forms.TextBox();
            this.diagnosis_TextA = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stage_CBox = new System.Windows.Forms.ComboBox();
            this.approved_CBox = new System.Windows.Forms.ComboBox();
            this.result_CBox = new System.Windows.Forms.ComboBox();
            this.issue_CBox = new System.Windows.Forms.ComboBox();
            this.bulkink_CBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rma_Text = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.back_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Printer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue Date";
            // 
            // issue_Date
            // 
            this.issue_Date.Location = new System.Drawing.Point(613, 105);
            this.issue_Date.Margin = new System.Windows.Forms.Padding(4);
            this.issue_Date.Name = "issue_Date";
            this.issue_Date.Size = new System.Drawing.Size(261, 22);
            this.issue_Date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return Date";
            // 
            // return_Date
            // 
            this.return_Date.Location = new System.Drawing.Point(613, 165);
            this.return_Date.Margin = new System.Windows.Forms.Padding(4);
            this.return_Date.Name = "return_Date";
            this.return_Date.Size = new System.Drawing.Size(261, 22);
            this.return_Date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Closed";
            // 
            // closed_CBox
            // 
            this.closed_CBox.FormattingEnabled = true;
            this.closed_CBox.Items.AddRange(new object[] {
            "Issued",
            "Closed",
            "Issued Refurbished"});
            this.closed_CBox.Location = new System.Drawing.Point(39, 225);
            this.closed_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.closed_CBox.Name = "closed_CBox";
            this.closed_CBox.Size = new System.Drawing.Size(148, 24);
            this.closed_CBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer Name";
            // 
            // customer_Text
            // 
            this.customer_Text.Location = new System.Drawing.Point(23, 38);
            this.customer_Text.Margin = new System.Windows.Forms.Padding(4);
            this.customer_Text.Name = "customer_Text";
            this.customer_Text.Size = new System.Drawing.Size(352, 22);
            this.customer_Text.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Faulty Serial #";
            // 
            // faulty_Text
            // 
            this.faulty_Text.Location = new System.Drawing.Point(23, 98);
            this.faulty_Text.Margin = new System.Windows.Forms.Padding(4);
            this.faulty_Text.Name = "faulty_Text";
            this.faulty_Text.Size = new System.Drawing.Size(169, 22);
            this.faulty_Text.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Replacement Serial #";
            // 
            // replacement_Text
            // 
            this.replacement_Text.Location = new System.Drawing.Point(205, 98);
            this.replacement_Text.Margin = new System.Windows.Forms.Padding(4);
            this.replacement_Text.Name = "replacement_Text";
            this.replacement_Text.Size = new System.Drawing.Size(169, 22);
            this.replacement_Text.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Printer Type";
            // 
            // printer_CBox
            // 
            this.printer_CBox.FormattingEnabled = true;
            this.printer_CBox.Items.AddRange(new object[] {
            "NeuraLabel - Replacement (Standard)",
            "NeuraLabel - Replacement (Straight-Through)",
            "NeuraLabel - Replacement (C-Path)",
            "NeuraLabel - RMA (Standard)",
            "NeuraLabel - RMA (Straight-Through)",
            "NeuraLabel - RMA (C-Path)",
            "NeuraLog - Replacement (Standard)",
            "NueraLog - Replacement (Straight-Through)",
            "NeuraLog - Replacement (C-Path)",
            "NeuraLog - RMA (Standard)",
            "NeuraLog - RMA (Straight-Through)",
            "NeuraLog - RMA (C-Path)"});
            this.printer_CBox.Location = new System.Drawing.Point(193, 159);
            this.printer_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.printer_CBox.Name = "printer_CBox";
            this.printer_CBox.Size = new System.Drawing.Size(205, 24);
            this.printer_CBox.TabIndex = 15;
            this.printer_CBox.SelectedIndexChanged += new System.EventHandler(this.Printer_CBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name:";
            // 
            // printername_Label
            // 
            this.printername_Label.AutoSize = true;
            this.printername_Label.Location = new System.Drawing.Point(15, 32);
            this.printername_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printername_Label.Name = "printername_Label";
            this.printername_Label.Size = new System.Drawing.Size(0, 17);
            this.printername_Label.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Type:";
            // 
            // type_Label
            // 
            this.type_Label.AutoSize = true;
            this.type_Label.Location = new System.Drawing.Point(139, 32);
            this.type_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type_Label.Name = "type_Label";
            this.type_Label.Size = new System.Drawing.Size(0, 17);
            this.type_Label.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(293, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Variant:";
            // 
            // variant_Label
            // 
            this.variant_Label.AutoSize = true;
            this.variant_Label.Location = new System.Drawing.Point(293, 32);
            this.variant_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.variant_Label.Name = "variant_Label";
            this.variant_Label.Size = new System.Drawing.Size(0, 17);
            this.variant_Label.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.variant_Label);
            this.panel1.Controls.Add(this.printername_Label);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.type_Label);
            this.panel1.Location = new System.Drawing.Point(433, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 54);
            this.panel1.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 278);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "Notes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(293, 212);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Diagnosis";
            // 
            // notes_TextA
            // 
            this.notes_TextA.Location = new System.Drawing.Point(23, 233);
            this.notes_TextA.Margin = new System.Windows.Forms.Padding(4);
            this.notes_TextA.Multiline = true;
            this.notes_TextA.Name = "notes_TextA";
            this.notes_TextA.Size = new System.Drawing.Size(252, 254);
            this.notes_TextA.TabIndex = 25;
            // 
            // diagnosis_TextA
            // 
            this.diagnosis_TextA.Location = new System.Drawing.Point(297, 233);
            this.diagnosis_TextA.Margin = new System.Windows.Forms.Padding(4);
            this.diagnosis_TextA.Multiline = true;
            this.diagnosis_TextA.Name = "diagnosis_TextA";
            this.diagnosis_TextA.Size = new System.Drawing.Size(252, 254);
            this.diagnosis_TextA.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.stage_CBox);
            this.panel2.Controls.Add(this.approved_CBox);
            this.panel2.Controls.Add(this.result_CBox);
            this.panel2.Controls.Add(this.issue_CBox);
            this.panel2.Controls.Add(this.bulkink_CBox);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(575, 233);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 211);
            this.panel2.TabIndex = 27;
            // 
            // stage_CBox
            // 
            this.stage_CBox.FormattingEnabled = true;
            this.stage_CBox.Items.AddRange(new object[] {
            "Outstanding RMA",
            "Closed/Received RMA",
            "Loaner",
            "Upgrade",
            "Possible Sale",
            "Swap",
            "Sale",
            "Demo Unit"});
            this.stage_CBox.Location = new System.Drawing.Point(100, 171);
            this.stage_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.stage_CBox.Name = "stage_CBox";
            this.stage_CBox.Size = new System.Drawing.Size(147, 24);
            this.stage_CBox.TabIndex = 9;
            // 
            // approved_CBox
            // 
            this.approved_CBox.FormattingEnabled = true;
            this.approved_CBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.approved_CBox.Location = new System.Drawing.Point(100, 132);
            this.approved_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.approved_CBox.Name = "approved_CBox";
            this.approved_CBox.Size = new System.Drawing.Size(147, 24);
            this.approved_CBox.TabIndex = 8;
            // 
            // result_CBox
            // 
            this.result_CBox.FormattingEnabled = true;
            this.result_CBox.Items.AddRange(new object[] {
            "Fixed",
            "Scrap",
            "Disassembled",
            "Keep",
            "Unprocessed"});
            this.result_CBox.Location = new System.Drawing.Point(100, 91);
            this.result_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.result_CBox.Name = "result_CBox";
            this.result_CBox.Size = new System.Drawing.Size(147, 24);
            this.result_CBox.TabIndex = 7;
            // 
            // issue_CBox
            // 
            this.issue_CBox.FormattingEnabled = true;
            this.issue_CBox.Items.AddRange(new object[] {
            "Hardware",
            "Media Jam",
            "Print Quality",
            "Marks",
            "Error Code",
            "Network Board",
            "Freeze",
            "Other"});
            this.issue_CBox.Location = new System.Drawing.Point(100, 50);
            this.issue_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.issue_CBox.Name = "issue_CBox";
            this.issue_CBox.Size = new System.Drawing.Size(147, 24);
            this.issue_CBox.TabIndex = 6;
            // 
            // bulkink_CBox
            // 
            this.bulkink_CBox.FormattingEnabled = true;
            this.bulkink_CBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.bulkink_CBox.Location = new System.Drawing.Point(100, 11);
            this.bulkink_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.bulkink_CBox.Name = "bulkink_CBox";
            this.bulkink_CBox.Size = new System.Drawing.Size(147, 24);
            this.bulkink_CBox.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 175);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "Stage:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 135);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "Approved:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 95);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 17);
            this.label19.TabIndex = 2;
            this.label19.Text = "Result:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 54);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Issue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bulk Ink:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(576, 466);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 17);
            this.label22.TabIndex = 28;
            this.label22.Text = "Error Codes:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(671, 463);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(179, 22);
            this.textBox6.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rma_Text);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.diagnosis_TextA);
            this.panel3.Controls.Add(this.replacement_Text);
            this.panel3.Controls.Add(this.notes_TextA);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.faulty_Text);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.customer_Text);
            this.panel3.Controls.Add(this.printer_CBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(16, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 517);
            this.panel3.TabIndex = 30;
            // 
            // rma_Text
            // 
            this.rma_Text.Location = new System.Drawing.Point(417, 38);
            this.rma_Text.Margin = new System.Windows.Forms.Padding(4);
            this.rma_Text.Name = "rma_Text";
            this.rma_Text.Size = new System.Drawing.Size(132, 22);
            this.rma_Text.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(413, 18);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 17);
            this.label23.TabIndex = 0;
            this.label23.Text = "RMA #";
            // 
            // back_Button
            // 
            this.back_Button.Location = new System.Drawing.Point(39, 30);
            this.back_Button.Margin = new System.Windows.Forms.Padding(4);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(100, 28);
            this.back_Button.TabIndex = 31;
            this.back_Button.Text = "Back";
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(776, 31);
            this.add_Button.Margin = new System.Windows.Forms.Padding(4);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(100, 28);
            this.add_Button.TabIndex = 32;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 567);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closed_CBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.return_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.issue_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker issue_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker return_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox closed_CBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customer_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox faulty_Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox replacement_Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox printer_CBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label printername_Label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label type_Label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label variant_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox notes_TextA;
        private System.Windows.Forms.TextBox diagnosis_TextA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stage_CBox;
        private System.Windows.Forms.ComboBox approved_CBox;
        private System.Windows.Forms.ComboBox result_CBox;
        private System.Windows.Forms.ComboBox issue_CBox;
        private System.Windows.Forms.ComboBox bulkink_CBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox rma_Text;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Button add_Button;
    }
}