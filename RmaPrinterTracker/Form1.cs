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
        public Form1()
        {
            InitializeComponent();

			conn = Connection.getConnection("localhost", "rma_printer", 3306, "root", "Sfn8tjpansv!");	

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
			using (conn = Connection.getConnection("localhost", "rma_printer", 3306, "root", "Sfn8tjpansv!"))
			{
				conn.Open();
				MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT rmaid AS RMA, company_name AS 'Company Name', closed AS Closed, issue_date AS 'Issue Date', faulty_sn AS 'Faulty SN', replacement_sn AS 'Replacement SN', returned_date AS 'Returned Date', notes AS Notes, diagnosis AS Diagnosis, bulkink AS 'Bulk Ink?', issue_category AS 'Issue Catagory', result AS Result, approved AS Approved FROM printer", conn);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
              
				dataGridView1.DataSource = dataTable;
                this.dataGridView1.Columns[0].Width = 50;
                this.dataGridView1.Columns[3].Width = 70;
                this.dataGridView1.Columns[6].Width = 70;
                this.dataGridView1.Columns[7].Width = 218;
                this.dataGridView1.Columns[8].Width = 218;
                this.dataGridView1.Columns[9].Width = 50;
                this.dataGridView1.Columns[12].Width = 60;
            }
		}

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            rma_Text.ResetText();
            company_Text.ResetText();
            serialnumber_Text.ResetText();
            printertype_CBox.Items.Clear();
            serialnumber_CBox.Items.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
