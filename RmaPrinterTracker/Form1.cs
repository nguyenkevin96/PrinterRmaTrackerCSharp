using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RmaPrinterTracker
{
    public partial class Form1 : Form
    {
		//readonly MySqlConnection conn = null;
        readonly DataTable dataTable = new DataTable();
        string selectedRowRmaNumber;
        MySqlDataAdapter sqlDataAdapter;

        public Form1()
        {
            InitializeComponent();

            var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200");


            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    connectionStatus.Text = "Connected to MySql";
                    connectionStatus.ForeColor = Color.Green;
                }
                else
                {
                    connectionStatus.Text = "Failed";
                    connectionStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

			LoadData();
        }

		private void LoadData()
		{
			using (var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200"))
			{
                dataTable.Clear();
                sqlDataAdapter = new MySqlDataAdapter("SELECT rmaid AS RMA, company_name AS 'Company Name', closed AS Closed, issue_date AS 'Issue Date', faulty_sn AS 'Faulty SN', replacement_sn AS 'Replacement SN', returned_date AS 'Returned Date', notes AS Notes, diagnosis AS Diagnosis, bulkink AS 'Bulk Ink?', issue_category AS 'Issue Catagory', result AS Result, approved AS Approved, printertid AS 'Printer Type', printer_stageid AS 'Stage' FROM printer", conn);
				sqlDataAdapter.Fill(dataTable);
              
				neuralabelReplacement_Printer.DataSource = dataTable;
                neuralabelReplacement_Printer.Columns[0].Width = 50;
                neuralabelReplacement_Printer.Columns[3].Width = 70;
                neuralabelReplacement_Printer.Columns[6].Width = 70;
                neuralabelReplacement_Printer.Columns[7].Width = 218;
                neuralabelReplacement_Printer.Columns[8].Width = 218;
                neuralabelReplacement_Printer.Columns[9].Width = 50;
                neuralabelReplacement_Printer.Columns[12].Width = 60;
                neuralabelReplacement_Printer.Columns[13].Width = 45;
                neuralabelReplacement_Printer.Columns[14].Visible = false;
            }
		}

        private void RowColor(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow dataRow in neuralabelReplacement_Printer.Rows)
            {
                int printerStage = Convert.ToInt32(dataRow.Cells[14].Value) + 1;
                switch (printerStage)
                {
                    case 1:
                        dataRow.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case 2:
                        dataRow.DefaultCellStyle.BackColor = Color.LemonChiffon;
                        break;
                    case 3:
                        dataRow.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    case 4:
                        dataRow.DefaultCellStyle.BackColor = Color.Teal;
                        break;
                    case 5:
                        dataRow.DefaultCellStyle.BackColor = Color.PaleGreen;
                        break;
                    case 6:
                        dataRow.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case 7:
                        dataRow.DefaultCellStyle.BackColor = Color.HotPink;
                        break;
                    case 8:
                        dataRow.DefaultCellStyle.BackColor = Color.Gray;
                        break;
                }
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            rma_Text.ResetText();
            company_Text.ResetText();
            serialnumber_Text.ResetText();
            printertype_CBox.SelectedIndex = -1;
            serialnumber_CBox.SelectedIndex = -1;
            dataTable.DefaultView.RowFilter = string.Empty;
        }

        //Add printer Button
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            LoadData();
        }

        //Refresh Button
        private void Button2_Click(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Empty;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.Update(dataTable);
        }

        /*
         * The different serach filters 
         * in the form to filter out the 
         * data
         */
        private void Rma_Text_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "RMA", rma_Text.Text);
        }

        private void Company_Text_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Company Name", company_Text.Text);
        }

        private void Serialnumber_Text_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", serialnumber_CBox.SelectedItem.ToString(), serialnumber_Text.Text);
        }

        private void Printertype_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rowFilterString = "";
            switch((printertype_CBox.SelectedIndex) + 1)
            {
                case 1:
                    rowFilterString = "[{0}] IN (1, 4, 7, 10)";
                    break;
                case 2:
                    rowFilterString = "[{0}] IN (2, 5, 8, 11)";
                    break;
                case 3:
                    rowFilterString = "[{0}] IN (3, 6, 9, 12)";
                    break;
            }
            dataTable.DefaultView.RowFilter = string.Format(rowFilterString, "Printer Type");
        }


        /* Creates the Context Menu upon right
         * clicking in the DataGridView
         */
        private void DataGridView1_MouseRightClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Highlights the selected row
                neuralabelReplacement_Printer.ClearSelection();
                neuralabelReplacement_Printer.Rows[e.RowIndex].Selected = true;

                //Creates the Context menu containing the edit and delete options
                ContextMenuStrip handleEditAndDelete = new ContextMenuStrip();
                handleEditAndDelete.Items.Add("Edit");
                handleEditAndDelete.Items.Add("Delete");
                handleEditAndDelete.ItemClicked += new ToolStripItemClickedEventHandler(this.ContextMenuClicked);

                //Grabs the selected rows RMA to query
                DataGridViewRow selectedRow = neuralabelReplacement_Printer.Rows[e.RowIndex];
                selectedRowRmaNumber = selectedRow.Cells["RMA"].Value.ToString();

                //Opens the context menu at the cursor location
                var mouse = neuralabelReplacement_Printer.PointToClient(Cursor.Position);
                handleEditAndDelete.Show(neuralabelReplacement_Printer, mouse);
            }
        }

        /* 
         * Adding the listeners to check which
         * option the user clicks on
         */
        private void ContextMenuClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem selectedContextMenu = e.ClickedItem;
            if (selectedContextMenu.Text == "Edit")
            {
/*                MessageBox.Show("Edit has been clicked");
                MessageBox.Show("The message contains " + selectedRowRmaNumber);*/
                Form2 editForm = new Form2();
                editForm.FormClosed += new FormClosedEventHandler(Form2ClosedRefresh);
                editForm.HandleEditForm(editForm, Convert.ToInt32(selectedRowRmaNumber));
            }

            if(selectedContextMenu.Text == "Delete")
            {
                MessageBox.Show("Delete has been clicked");

            }
        }

        //Refreshes the dataGridView in form 1 when form 2 closes from updating
        private void Form2ClosedRefresh(object sender, FormClosedEventArgs e)
        {
            dataTable.Clear();
            sqlDataAdapter.Fill(dataTable);
        }
    }
}
