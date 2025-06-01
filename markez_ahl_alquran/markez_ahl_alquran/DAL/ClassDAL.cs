using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace markez_ahl_alquran.DAL
{
    public class ClassDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        // جلب جميع الحلقات مع أسماء المعلمين
        public DataTable GetAllClasses()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT C.ClassID, C.ClassName, T.FullName AS TeacherName " +
                               "FROM Classes C LEFT JOIN Teachers T ON C.TeacherID = T.TeacherID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // إضافة حلقة جديدة
        public void AddClass(string className, int teacherID)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "INSERT INTO Classes (ClassName, TeacherID) VALUES (@ClassName, @TeacherID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassName", className);
                cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // حذف حلقة
        public void DeleteClass(int classID)
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "DELETE FROM Classes WHERE ClassID = @ClassID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassID", classID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // جلب جميع المعلمين لربطهم بالحلقات
        public DataTable GetAllTeachers()
        {
            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT TeacherID, FullName FROM Teachers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public string GetClassNameById(int classId)
        {
            string className = "";

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                string query = "SELECT ClassName FROM Classes WHERE ClassID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", classId);

                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                    className = result.ToString();
            }

            return className;
        }


    }
}
