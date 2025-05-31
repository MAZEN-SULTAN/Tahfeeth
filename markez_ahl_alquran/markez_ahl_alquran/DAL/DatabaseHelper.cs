using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace markez_ahl_alquran.DAL
{
    public class DatabaseHelper
    {
        // سلسلة الاتصال بقاعدة البيانات
        private string connectionString = "Data Source=MAZEN-SULTAN;Initial Catalog=TahfeethDB;Integrated Security=True;";

        // دالة لإرجاع اتصال جديد
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
    
}
