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
        public void InsertStudentProgress(int studentId, int year, int month, string memFrom, string memTo,string memoEvalu, string revFrom, string revTo, string revEvalu)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = @"INSERT INTO StudentProgress 
                         (StudentID, RecordDate, MemorizedFrom, MemorizedTo, MemorizedEvaluation, ReviewedFrom, ReviewedTo, ReviewedEvaluation)
                         VALUES 
                         (@StudentID, @RecordDate, @MemorizedFrom, @MemorizedTo, @MemorizedEvaluation, @ReviewedFrom, @ReviewedTo, @ReviewedEvaluation)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@RecordDate", new DateTime(year, month, 1));
                cmd.Parameters.AddWithValue("@MemorizedFrom", memFrom ?? "");
                cmd.Parameters.AddWithValue("@MemorizedTo", memTo ?? "");
                cmd.Parameters.AddWithValue("@MemorizedEvaluation", memoEvalu ?? "");
                cmd.Parameters.AddWithValue("@ReviewedFrom", revFrom ?? "");
                cmd.Parameters.AddWithValue("@ReviewedTo", revTo ?? "");
                cmd.Parameters.AddWithValue("@ReviewedEvaluation", revEvalu ?? "");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
