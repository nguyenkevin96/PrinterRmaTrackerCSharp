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
            this.rma_Label = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(257, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Printer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue Date";
            // 
            // issue_Date
            // 
            this.issue_Date.Location = new System.Drawing.Point(460, 85);
            this.issue_Date.Name = "issue_Date";
            this.issue_Date.Size = new System.Drawing.Size(197, 20);
            this.issue_Date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return Date";
            // 
            // return_Date
            // 
            this.return_Date.Location = new System.Drawing.Point(460, 134);
            this.return_Date.Name = "return_Date";
            this.return_Date.Size = new System.Drawing.Size(197, 20);
            this.return_Date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
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
            this.closed_CBox.Location = new System.Drawing.Point(29, 183);
            this.closed_CBox.Name = "closed_CBox";
            this.closed_CBox.Size = new System.Drawing.Size(112, 21);
            this.closed_CBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer Name";
            // 
            // customer_Text
            // 
            this.customer_Text.Location = new System.Drawing.Point(17, 31);
            this.customer_Text.Name = "customer_Text";
            this.customer_Text.Size = new System.Drawing.Size(265, 20);
            this.customer_Text.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Faulty Serial #";
            // 
            // faulty_Text
            // 
            this.faulty_Text.Location = new System.Drawing.Point(17, 80);
            this.faulty_Text.Name = "faulty_Text";
            this.faulty_Text.Size = new System.Drawing.Size(128, 20);
            this.faulty_Text.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Replacement Serial #";
            // 
            // replacement_Text
            // 
            this.replacement_Text.Location = new System.Drawing.Point(154, 80);
            this.replacement_Text.Name = "replacement_Text";
            this.replacement_Text.Size = new System.Drawing.Size(128, 20);
            this.replacement_Text.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Printer Type";
            // 
            // printer_CBox
            // 
            this.printer_CBox.FormattingEnabled = true;
            this.printer_CBox.Items.AddRange(new object[] {
            "Standard",
            "Straight-Through",
            "C-Path"});
            this.printer_CBox.Location = new System.Drawing.Point(145, 129);
            this.printer_CBox.Name = "printer_CBox";
            this.printer_CBox.Size = new System.Drawing.Size(155, 21);
            this.printer_CBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "RMA:";
            // 
            // rma_Label
            // 
            this.rma_Label.AutoSize = true;
            this.rma_Label.Location = new System.Drawing.Point(11, 26);
            this.rma_Label.Name = "rma_Label";
            this.rma_Label.Size = new System.Drawing.Size(41, 13);
            this.rma_Label.TabIndex = 17;
            this.rma_Label.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Type:";
            // 
            // type_Label
            // 
            this.type_Label.AutoSize = true;
            this.type_Label.Location = new System.Drawing.Point(104, 26);
            this.type_Label.Name = "type_Label";
            this.type_Label.Size = new System.Drawing.Size(41, 13);
            this.type_Label.TabIndex = 19;
            this.type_Label.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Variant:";
            // 
            // variant_Label
            // 
            this.variant_Label.AutoSize = true;
            this.variant_Label.Location = new System.Drawing.Point(220, 26);
            this.variant_Label.Name = "variant_Label";
            this.variant_Label.Size = new System.Drawing.Size(41, 13);
            this.variant_Label.TabIndex = 21;
            this.variant_Label.Text = "label15";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.variant_Label);
            this.panel1.Controls.Add(this.rma_Label);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.type_Label);
            this.panel1.Location = new System.Drawing.Point(325, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 44);
            this.panel1.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Notes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(220, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Diagnosis";
            // 
            // notes_TextA
            // 
            this.notes_TextA.Location = new System.Drawing.Point(17, 189);
            this.notes_TextA.Multiline = true;
            this.notes_TextA.Name = "notes_TextA";
            this.notes_TextA.Size = new System.Drawing.Size(190, 207);
            this.notes_TextA.TabIndex = 25;
            // 
            // diagnosis_TextA
            // 
            this.diagnosis_TextA.Location = new System.Drawing.Point(223, 189);
            this.diagnosis_TextA.Multiline = true;
            this.diagnosis_TextA.Name = "diagnosis_TextA";
            this.diagnosis_TextA.Size = new System.Drawing.Size(190, 207);
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
            this.panel2.Location = new System.Drawing.Point(431, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 172);
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
            this.stage_CBox.Location = new System.Drawing.Point(75, 139);
            this.stage_CBox.Name = "stage_CBox";
            this.stage_CBox.Size = new System.Drawing.Size(111, 21);
            this.stage_CBox.TabIndex = 9;
            // 
            // approved_CBox
            // 
            this.approved_CBox.FormattingEnabled = true;
            this.approved_CBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.approved_CBox.Location = new System.Drawing.Point(75, 107);
            this.approved_CBox.Name = "approved_CBox";
            this.approved_CBox.Size = new System.Drawing.Size(111, 21);
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
            this.result_CBox.Location = new System.Drawing.Point(75, 74);
            this.result_CBox.Name = "result_CBox";
            this.result_CBox.Size = new System.Drawing.Size(111, 21);
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
            this.issue_CBox.Location = new System.Drawing.Point(75, 41);
            this.issue_CBox.Name = "issue_CBox";
            this.issue_CBox.Size = new System.Drawing.Size(111, 21);
            this.issue_CBox.TabIndex = 6;
            // 
            // bulkink_CBox
            // 
            this.bulkink_CBox.FormattingEnabled = true;
            this.bulkink_CBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.bulkink_CBox.Location = new System.Drawing.Point(75, 9);
            this.bulkink_CBox.Name = "bulkink_CBox";
            this.bulkink_CBox.Size = new System.Drawing.Size(111, 21);
            this.bulkink_CBox.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Stage:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Approved:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Result:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Issue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bulk Ink:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(432, 379);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Error Codes:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(503, 376);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 20);
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
            this.panel3.Location = new System.Drawing.Point(12, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 420);
            this.panel3.TabIndex = 30;
            // 
            // rma_Text
            // 
            this.rma_Text.Location = new System.Drawing.Point(313, 31);
            this.rma_Text.Name = "rma_Text";
            this.rma_Text.Size = new System.Drawing.Size(100, 20);
            this.rma_Text.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(310, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "RMA #";
            // 
            // back_Button
            // 
            this.back_Button.Location = new System.Drawing.Point(29, 24);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(75, 23);
            this.back_Button.TabIndex = 31;
            this.back_Button.Text = "Back";
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(582, 25);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(75, 23);
            this.add_Button.TabIndex = 32;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 461);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label rma_Label;
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