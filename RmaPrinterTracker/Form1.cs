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
		MySqlConnection conn = null;
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

			conn = Connection.getConnection();	

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

			loadData();
        }



		private void loadData()
		{
			using (conn)
			{
                dataTable.Clear();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT rmaid AS RMA, company_name AS 'Company Name', closed AS Closed, issue_date AS 'Issue Date', faulty_sn AS 'Faulty SN', replacement_sn AS 'Replacement SN', returned_date AS 'Returned Date', notes AS Notes, diagnosis AS Diagnosis, bulkink AS 'Bulk Ink?', issue_category AS 'Issue Catagory', result AS Result, approved AS Approved, printertid AS 'Printer Type', printer_stageid AS 'Stage' FROM printer", conn);
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

        //
        private void RowColor(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow dataRow in neuralabelReplacement_Printer.Rows)
            {
                string printerStage = dataRow.Cells[14].Value.ToString();
                switch (printerStage)
                {
                    case "1":
                        dataRow.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "2":
                        dataRow.DefaultCellStyle.BackColor = Color.LemonChiffon;
                        break;
                    case "3":
                        dataRow.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    case "4":
                        dataRow.DefaultCellStyle.BackColor = Color.Teal;
                        break;
                    case "5":
                        dataRow.DefaultCellStyle.BackColor = Color.PaleGreen;
                        break;
                    case "6":
                        dataRow.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case "7":
                        dataRow.DefaultCellStyle.BackColor = Color.HotPink;
                        break;
                    case "8":
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
            loadData();
        }
        //Refresh Button
        private void Button2_Click(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Empty;
        }

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
            dataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", "Printer Type", printertype_CBox.SelectedIndex + 1);
        }

        private void contextMenuDataGridView(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            
        }

        /*private void dataGridView1_MouseRightClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                neuralabelReplacement_Printer.ClearSelection();
                neuralabelReplacement_Printer.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ContextItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem selected = e.ClickedItem;
            if(selected.Text == "Edit")
            {
                MessageBox.Show("Edit has been clicked");
                string test = neuralabelReplacement_Printer.CurrentRow.Cells["RMA"].FormattedValue.ToString();
                MessageBox.Show("You have selected " + test);
            }

            if(selected.Text == "Delete")
            {
                MessageBox.Show("Delete has been clicked");
            }
        }*/
    }
}
