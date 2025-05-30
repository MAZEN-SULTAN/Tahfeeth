using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace markez_ahl_alquran.DAL
{
    public class TeacherDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // جلب جميع المعلمين
        public DataTable GetAllTeachers()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT * FROM Teachers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // إضافة معلم جديد
        public void AddTeacher(string fullName, decimal salary, decimal phonenumber)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "INSERT INTO Teachers (FullName, Salary, PhoneNumber) VALUES (@FullName, @Salary, @PhoneNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // حذف معلم
        public void DeleteTeacher(int teacherID)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
