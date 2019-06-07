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
            using (var conn = new MySqlConnection("Server=localhost;database=rma_printer;UID=root;password=Sfn8tjpansv!"))
            {
                conn.Open();
                string insertStatement = "INSERT INTO printer (rmaid, company_name, closed, issue_date, faulty_sn, replacement_sn, returned_date, notes, diagnosis, bulkink, issue_category, result, approved, printertid, printer_stageid) " +
                    "VALUES (@rmaid, @company, @closed, @issueDate, @faulty, @replacement, @returnDate, @notes, @diagnosis, @bulkink, @issueCategory, @result, @approved, @printertypeid, @printerstage";
                using (MySqlCommand query = new MySqlCommand(insertStatement, conn))
                {
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
                    query.Parameters.AddWithValue("@printertypeid", (printer_CBox.SelectedIndex + 1));
                    query.Parameters.AddWithValue("@printerstage", (stage_CBox.SelectedIndex + 1));

                    MessageBox.Show(String.Format("Printer Information: \n" +
                    "Rma:{0}\n" +
                    "Company:{1}\n" +
                    "Closed?:{2}\n" +
                    "Issue Date:{3}\n" +
                    "Faulty SN:{4}\n" +
                    "Replacement SN:{5}\n" +
                    "Return Date:{6}\n" +
                    "Notes:{7}\n" +
                    "Diagnosis:{8}\n" +
                    "Bulk Ink?:{9}\n" +
                    "Issue Category:{10}\n" +
                    "Result:{11}\n" +
                    "Approved:{12}\n" +
                    "Printer Type:{13} (Id:{14})\n" +
                    "Printer Stage:{15} (Id:{16})",
                    Int32.Parse(rma_Text.Text),
                    customer_Text.Text,
                    closed_CBox.SelectedItem.ToString(),
                    issue_Date.Value,
                    faulty_Text.Text,
                    replacement_Text.Text,
                    return_Date.Value,
                    notes_TextA.Text,
                    diagnosis_TextA.Text,
                    bulkink_CBox.SelectedItem.ToString() == "Yes" ? true : false,
                    issue_CBox.SelectedItem.ToString(),
                    result_CBox.SelectedItem.ToString(),
                    approved_CBox.SelectedItem.ToString() == "Yes" ? true : false,
                    printer_CBox.SelectedItem.ToString(),
                    printer_CBox.SelectedIndex + 1,
                    stage_CBox.SelectedItem.ToString(),
                    stage_CBox.SelectedIndex + 1));

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

