using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenToko
{
    internal class Koneksi
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=TokoDB;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
