using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class DatabaseHandler
    {
        private static String ServerName = @"SERVER BURAYA GELECEK";

        private static SqlConnection sqlConnection;

        public static SqlConnection GetNewConnection()
        {
            try
            {
                //Data Source=SERVER ADRESI;Initial Catalog=LIBRARYMS;Integrated Security=True
                sqlConnection = new SqlConnection("Data Source='" + ServerName + "'; Initial Catalog=LIBRARYMS;Integrated Security=True");
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e.ToString());
            }
            return sqlConnection;
        }

        public static String GetServerName()
        {
            return ServerName;
        }

    }
}
