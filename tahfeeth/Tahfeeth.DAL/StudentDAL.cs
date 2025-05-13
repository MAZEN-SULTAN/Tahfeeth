using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tahfeeth.DAL
{
    public class StudentDAL
    {
        private string connectionString = "Data Source=AIMAN-ALSHUJAA;Initial Catalog=TahfeethDB;Integrated Security=True;";

        public bool AddStudent(string fullName, DateTime birthDate, DateTime enrollDate, int classId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (FullName, BirthDate, EnrollDate, ClassId) VALUES (@FullName, @BirthDate, @EnrollDate, @ClassId)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@EnrollDate", enrollDate);
                cmd.Parameters.AddWithValue("@ClassId", classId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}