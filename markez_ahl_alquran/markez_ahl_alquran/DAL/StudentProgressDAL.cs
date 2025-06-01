using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markez_ahl_alquran.DAL
{
    internal class StudentProgressDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();
        public void InsertStudentProgress(int studentId, int year, int month, string memFrom, string memTo, string revFrom, string revTo)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"INSERT INTO StudentProgress 
                         (StudentID, RecordDate, MemorizedFrom, MemorizedTo, ReviewedFrom, ReviewedTo)
                         VALUES 
                         (@StudentID, @RecordDate, @MemorizedFrom, @MemorizedTo, @ReviewedFrom, @ReviewedTo)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@RecordDate", new DateTime(year, month, 1));
                cmd.Parameters.AddWithValue("@MemorizedFrom", memFrom ?? "");
                cmd.Parameters.AddWithValue("@MemorizedTo", memTo ?? "");
                cmd.Parameters.AddWithValue("@ReviewedFrom", revFrom ?? "");
                cmd.Parameters.AddWithValue("@ReviewedTo", revTo ?? "");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
