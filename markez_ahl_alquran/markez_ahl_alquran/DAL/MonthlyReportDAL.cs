using System;
using System.Data;
using System.Data.SqlClient;

namespace markez_ahl_alquran.DAL
{
    public class MonthlyReportDAL
    {
        private readonly SqlConnection connection;

        public MonthlyReportDAL()
        {
            //DatabaseHelper db = new DatabaseHelper();
            connection = new SqlConnection(@"Data Source=MAZEN-SULTAN;Initial Catalog=TahfeethDB;Integrated Security=True");
        }

        public bool AddMonthlyReport(int studentId, int month, int year, int daysPresent, int daysAbsent, string notes)
        {
            try
            {
                string query = "INSERT INTO MonthlyReport (StudentID, Month, Year, DaysPresent, DaysAbsent, Notes) " +
                               "VALUES (@StudentID, @Month, @Year, @DaysPresent, @DaysAbsent, @Notes)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@DaysPresent", daysPresent);
                cmd.Parameters.AddWithValue("@DaysAbsent", daysAbsent);
                cmd.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("خطأ أثناء إضافة التقرير: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
