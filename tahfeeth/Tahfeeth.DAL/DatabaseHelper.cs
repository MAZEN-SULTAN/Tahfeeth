using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tahfeeth.DAL
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=AIMAN-ALSHUJAA;Initial Catalog=TahfeethDB;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}


