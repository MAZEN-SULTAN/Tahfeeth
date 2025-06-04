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
            connection = new SqlConnection(@"Data Source=AIMAN-ALSHUJAA;Initial Catalog=TahfeethDB;Integrated Security=True");
        }

        public bool AddMonthlyReport(int studentId, int month, int year, int daysPresent, int excused, int unexcused, string notes)
        {
            try
            {
                string query = "INSERT INTO MonthlyReport (StudentID, Month, Year, DaysPresent, ExcusedAbsences,UnexcusedAbsences, Notes) " +
                               "VALUES (@StudentID, @Month, @Year, @DaysPresent, @ExcusedAbsences,@UnexcusedAbsences, @Notes)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@DaysPresent", daysPresent);
                cmd.Parameters.AddWithValue("@ExcusedAbsences", excused);
                cmd.Parameters.AddWithValue("@UnexcusedAbsences", unexcused);
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

        public DataTable GetMonthlyAttendance(int studentId, int month, int year)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = @"SELECT DaysPresent, ExcusedAbsences, UnexcusedAbsences
                         FROM MonthlyReport
                         WHERE StudentID = @StudentID AND [Month] = @Month AND [Year] = @Year";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("خطأ أثناء جلب بيانات الحضور والغياب: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public string GetMonthlyNotes(int studentId, int month, int year)
        {
            try
            {
                string query = @"SELECT Notes
                         FROM MonthlyReport
                         WHERE StudentID = @StudentID AND [Month] = @Month AND [Year] = @Year";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                connection.Open();
                object result = cmd.ExecuteScalar(); // لأننا نريد قيمة واحدة فقط

                return result != null ? result.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("خطأ أثناء جلب الملاحظات: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }





    }

}
