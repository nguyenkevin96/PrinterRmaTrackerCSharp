using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RmaPrinterTracker
{
    class Connection
    {
        public static MySqlConnection getConnection(string hostname, string database, int port, string username, string password)
        {
            String sqlConnectionQuery = String.Format("datasource={0};database={1};port={2};username={3};password={4}", hostname, database, port, username, password);

            MySqlConnection conn = new MySqlConnection(sqlConnectionQuery);

            return conn;
        }
    }
}
