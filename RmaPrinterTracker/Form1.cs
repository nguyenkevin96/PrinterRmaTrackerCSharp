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
        public Form1()
        {
            InitializeComponent();

            try
            {
                MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Sfn8tjpansv!");
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
        }
    }
}
