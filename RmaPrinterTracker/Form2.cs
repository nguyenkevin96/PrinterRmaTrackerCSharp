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
using System.Collections;

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
                    "VALUES (@rmaid, @company, @closed, @issueDate, @faulty, @replacement, @returnDate, @notes, @diagnosis, @bulkink, @issueCategory, @result, @approved, @printertypeid, @printerstage)";
                using (MySqlCommand query = new MySqlCommand(insertStatement, conn))
                {
                    query.Parameters.AddWithValue("@rmaid", Convert.ToInt32(rma_Text.Text));
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

                    query.ExecuteNonQuery();
                }
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (rmaIsValid())
            {
                addPrinter();
                this.DialogResult = DialogResult.OK;
            }
        }

        private Boolean rmaIsValid()
        {
            bool isValid = true;
            int i;
            string errorMessage = "";
            int numOfDigits = 0;
            ArrayList allRmaInDatabase = new ArrayList();

            if (int.TryParse(rma_Text.Text, out i))
            {
                int number = Convert.ToInt32(rma_Text.Text);
                do
                {
                    number = number / 10;
                    numOfDigits++;
                } while (number > 0);

                if(numOfDigits != 4)
                {
                    errorMessage = "Number should be 4 digits\n";
                    isValid = false;
                }
            } else
            {
                errorMessage += "Rma is not a number\n";
                isValid = false;
            }

            if (issue_Date.Value > return_Date.Value)
            {
                errorMessage += "The issued date should come before/equal the returned date\n";
                isValid = false;
            }

            using (conn)
            {
                conn.Open();
                string validateRma = "SELECT rmaid FROM printer";
                using (MySqlCommand run = new MySqlCommand(validateRma, conn))
                {
                    using(MySqlDataReader rmaReader = run.ExecuteReader())
                    {
                        while (rmaReader.Read())
                        {
                            allRmaInDatabase.Add((int)rmaReader["rmaid"]);
                        }
                    }
                }
                conn.Close();
            }

            if (allRmaInDatabase.Contains(Convert.ToInt32(rma_Text.Text))){
                errorMessage += rma_Text.Text + " already exists\n";
                isValid = false;
            }

            if(isValid == false)
            {
                MessageBox.Show(errorMessage);
            }

            return isValid;
        }

        private void Printer_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn)
            {
                conn.Open();
                string selectQuery = "SELECT * FROM printertype WHERE printertypeid = @id";
                MySqlCommand run = new MySqlCommand(selectQuery, conn);
                run.Parameters.AddWithValue("@id", printer_CBox.SelectedIndex + 1);
                
                using(MySqlDataReader resultSet = run.ExecuteReader())
                {
                    if (resultSet.Read())
                    {
                        printername_Label.Text = String.Format("{0}", resultSet["printername"]);
                        type_Label.Text = String.Format("{0}", resultSet["printerrmatype"]);
                        variant_Label.Text = String.Format("{0}", resultSet["printervariant"]);
                    }
                }
            }
        }
    }
}

