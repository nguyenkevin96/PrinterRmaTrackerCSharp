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
using System.Collections;

namespace RmaPrinterTracker
{
    public partial class Form2 : Form
    {
        //MySqlConnection conn = new MySqlConnection("Server=localhost;database=rma_printer;UID=root;password=Sfn8tjpansv!;MinimumPoolSize=1;maximumpoolsize=50");
        public MySqlDataAdapter printerTypes;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Adds a printer to the sql database 
        private void AddPrinter()
        {
            using (var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200"))
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
                conn.Close();
            }
        }

        private void SavePrinter()
        {
            using (var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200"))
            {
                conn.Open();
                string updatePrinter = "UPDATE printer SET rmaid = @rmaid, company_name = @company, closed = @closed, issue_date = @issueDate, faulty_sn = @faulty, replacement_sn = @replacement, returned_date = @returnDate, notes = @notes, diagnosis = @diagnosis, bulkink = @bulkink, issue_category = @issueCategory, result = @result, approved = @approved, printertid = @printertid, printer_stageid = @stage WHERE rmaid = @rmaid";

                using (MySqlCommand query = new MySqlCommand(updatePrinter, conn))
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
                    query.Parameters.AddWithValue("@printertid", (printer_CBox.SelectedIndex) + 1);
                    query.Parameters.AddWithValue("@stage", (stage_CBox.SelectedIndex));

                    query.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (RmaIsValid() && add_Button.Text == "Add")
            {
                AddPrinter();
                this.DialogResult = DialogResult.OK;
            }

            if(RmaIsValid() && add_Button.Text == "Save")
            {
                SavePrinter();
                this.DialogResult = DialogResult.OK;
            }
        }

        /*
         * The RmaIsValid function checks to 
         * make sure that the rma printer being
         * added or saved is correctly formatted
         */
        private Boolean RmaIsValid()
        {
            bool isValid = true;
            string errorMessage = "";
            int numOfDigits = 0;
            ArrayList allRmaInDatabase = new ArrayList();

            if (int.TryParse(rma_Text.Text, out int i))
            {
                int number = Convert.ToInt32(rma_Text.Text);
                do
                {
                    number /= 10;
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

            using (var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200"))
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

            if (allRmaInDatabase.Contains(Convert.ToInt32(rma_Text.Text)) && add_Button.Text == "Add"){
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
            DataSet dataSet = new DataSet();
            printerTypes = new MySqlDataAdapter();
            var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200");
            try
            {
                printerTypes.SelectCommand = new MySqlCommand(string.Format("SELECT * FROM printertype WHERE printertypeid = {0}", printer_CBox.SelectedIndex + 1), conn);
                printerTypes.Fill(dataSet);
                conn.Close();
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    printername_Label.Text = dr["printername"].ToString();
                    variant_Label.Text = dr["printervariant"].ToString();
                    type_Label.Text = dr["printerrmatype"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void HandleEditForm(Form2 form, int rmaNum)
        {
            using (var conn = new MySqlConnection("Server = localhost; database = rma_printer; UID = root; password = Sfn8tjpansv!;Max Pool Size=200"))
            {
                string selectQuery = "SELECT * " +
                    "FROM printer " +
                    "INNER JOIN printertype " +
                    "ON printer.printertid = printertype.printertypeid " +
                    "INNER JOIN stage " +
                    "ON printer.printer_stageid = stage.stageid " +
                    "WHERE rmaid = @rma";
                conn.Open();
                MySqlCommand run = new MySqlCommand(selectQuery, conn);
                run.Parameters.AddWithValue("@rma", rmaNum);
                using (MySqlDataReader resultSet = run.ExecuteReader())
                {
                    if (resultSet.Read())
                    {
                        customer_Text.Text = string.Format("{0}", resultSet["company_name"]);
                        rma_Text.Text = string.Format("{0}", resultSet["rmaid"]);
                        rma_Text.ReadOnly = true;
                        faulty_Text.Text = string.Format("{0}", resultSet["faulty_sn"]);
                        replacement_Text.Text = string.Format("{0}", resultSet["replacement_sn"]);
                        closed_CBox.SelectedItem = resultSet["closed"].ToString();
                        printer_CBox.SelectedIndex = Convert.ToInt32(resultSet["printertid"]) - 1;
                        issue_Date.Value = DateTime.Parse(resultSet["issue_date"].ToString());
                        return_Date.Value = DateTime.Parse(resultSet["returned_date"].ToString());
                        notes_TextA.Text = string.Format("{0}", resultSet["notes"]);
                        diagnosis_TextA.Text = string.Format("{0}", resultSet["diagnosis"]);
                        bulkink_CBox.SelectedItem = resultSet["bulkink"].ToString() == "True" ? "Yes" : "No";
                        issue_CBox.SelectedItem = resultSet["issue_category"].ToString();
                        result_CBox.SelectedItem = resultSet["result"].ToString();
                        approved_CBox.SelectedItem = resultSet["approved"].ToString() == "True" ? "Yes" : "No";
                        stage_CBox.SelectedIndex = Convert.ToInt32(resultSet["printer_stageid"]) - 1;
                        add_Button.Text = "Save";
                    }
                    conn.Close();
                }
            }
            form.ShowDialog();
        }   
    }
}

