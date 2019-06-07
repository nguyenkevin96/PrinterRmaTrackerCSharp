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
using System.Data.SqlClient;

namespace RmaPrinterTracker
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = Connection.getConnection();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addPrinter()
        {
            string insertStatement = "INSERT INTO printer VALUES (@rmaid, @company, @closed, @issueDate, @faulty, @replacement, @returnDate, @notes, @diagnosis, @bulkink, @issueCategory, @result, @approved, @printertypeid, @printerstage";
            using (/*Add Connection string find out why connection won't work*/){
                conn.Open();
                using(var query = new SqlCommand(insertStatement)){
                    query.Parameters.AddWithValue("@rmaid", Int32.Parse(rma_Text.Text));
                    query.Parameters.AddWithValue("@company", customer_Text.Text);
                    query.Parameters.AddWithValue("@closed", closed_CBox.SelectedItem.ToString());
                    query.Parameters.AddWithValue("@issueDate", issue_Date.Value);
                    query.Parameters.AddWithValue("@faulty", faulty_Text.Text);
                    query.Parameters.AddWithValue("@replacement", replacement_Text.Text);
                    query.Parameters.AddWithValue("@returnDate", return_Date.Value);
                    query.Parameters.AddWithValue("@notes", notes_TextA.Text);
                    query.Parameters.AddWithValue("@diagnosis", diagnosis_TextA.Text);
                    query.Parameters.AddWithValue("@bulkink", bulkink_CBox.SelectedItem.ToString() == "Yes" ? true : false);
                    query.Parameters.AddWithValue("@issueCategory", issue_CBox.SelectedItem.ToString());
                    query.Parameters.AddWithValue("@result", result_CBox.SelectedItem.ToString());
                    query.Parameters.AddWithValue("@approved", approved_CBox.SelectedItem.ToString() == "Yes" ? true : false);
                    query.Parameters.AddWithValue("@printertypeid", printer_CBox.SelectedIndex + 1);
                    query.Parameters.AddWithValue("@printerstage", stage_CBox.SelectedIndex + 1);

                    query.ExecuteNonQuery();
                }
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            addPrinter();
        }
    }
}
