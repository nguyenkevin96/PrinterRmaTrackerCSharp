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
                    label1.Text = "Connected to MySql";
                }
                else
                {
                    label1.Text = "Failed";
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
				MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("SELECT * FROM printer", conn);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);

				dataGridView1.DataSource = dataTable;
			}
		}
	}
}
