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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1415, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.connectionStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1407, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Neuralabel - Replacement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1391, 394);
            this.dataGridView1.TabIndex = 0;
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
            this.tabPage2.Size = new System.Drawing.Size(1407, 425);
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
            this.tabPage3.Size = new System.Drawing.Size(1407, 425);
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
            this.tabPage4.Size = new System.Drawing.Size(1407, 425);
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
            this.groupBox1.Size = new System.Drawing.Size(695, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by:";
            // 
            // serialnumber_Text
            // 
            this.serialnumber_Text.Location = new System.Drawing.Point(430, 55);
            this.serialnumber_Text.Margin = new System.Windows.Forms.Padding(4);
            this.serialnumber_Text.Name = "serialnumber_Text";
            this.serialnumber_Text.Size = new System.Drawing.Size(251, 22);
            this.serialnumber_Text.TabIndex = 9;
            // 
            // serialnumber_CBox
            // 
            this.serialnumber_CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialnumber_CBox.FormattingEnabled = true;
            this.serialnumber_CBox.Items.AddRange(new object[] {
            "Faulty",
            "Replacement"});
            this.serialnumber_CBox.Location = new System.Drawing.Point(276, 53);
            this.serialnumber_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.serialnumber_CBox.Name = "serialnumber_CBox";
            this.serialnumber_CBox.Size = new System.Drawing.Size(147, 24);
            this.serialnumber_CBox.TabIndex = 1;
            // 
            // company_Text
            // 
            this.company_Text.Location = new System.Drawing.Point(361, 27);
            this.company_Text.Margin = new System.Windows.Forms.Padding(4);
            this.company_Text.Name = "company_Text";
            this.company_Text.Size = new System.Drawing.Size(320, 22);
            this.company_Text.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 30);
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
            this.printertype_CBox.Location = new System.Drawing.Point(122, 53);
            this.printertype_CBox.Margin = new System.Windows.Forms.Padding(4);
            this.printertype_CBox.Name = "printertype_CBox";
            this.printertype_CBox.Size = new System.Drawing.Size(146, 24);
            this.printertype_CBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Printer Type:";
            // 
            // rma_Text
            // 
            this.rma_Text.Location = new System.Drawing.Point(122, 27);
            this.rma_Text.Margin = new System.Windows.Forms.Padding(4);
            this.rma_Text.Name = "rma_Text";
            this.rma_Text.Size = new System.Drawing.Size(111, 22);
            this.rma_Text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rma Number";
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(719, 134);
            this.clear_Button.Margin = new System.Windows.Forms.Padding(4);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(53, 29);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1319, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Printer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private Button button1;
    }
}

