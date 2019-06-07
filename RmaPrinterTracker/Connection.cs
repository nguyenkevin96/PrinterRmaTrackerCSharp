using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace RmaPrinterTracker
{
    class Connection
    {
        public static MySqlConnection getConnection()
        {
            String sqlConnectionQuery = String.Format("datasource={0};database={1};port={2};username={3};password={4}", "localhost", "rma_printer", 3306, "root", "Sfn8tjpansv!");

            MySqlConnection conn = new MySqlConnection(sqlConnectionQuery);

            return conn;
        }
    }
}
