using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using markez_ahl_alquran.BL; // لأننا سنستخدم كائن الطالب Student
using System.Windows.Forms;
using System.Data;

namespace markez_ahl_alquran.DAL
{
    public class StudentsDAL
    {
        DatabaseHelper db = new DatabaseHelper(); // الاتصال بالقاعدة

        public bool InsertStudent(Students student)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "INSERT INTO Students (FullName, BirthDate, JoinDate, ClassID, PhoneNumber) VALUES (@FullName, @BirthDate, @JoinDate, @ClassID, @PhoneNumber)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // إضافة القيم
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@BirthDate", student.BirthDate);
                    cmd.Parameters.AddWithValue("@JoinDate", student.JoinDate);
                    cmd.Parameters.AddWithValue("@ClassID", student.ClassID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);

                    conn.Open();            // فتح الاتصال
                    cmd.ExecuteNonQuery();  // تنفيذ الأمر
                    return true;            // تم الحفظ بنجاح
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
                return false;
            }
        }

        public DataTable GetAllStudents()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = @"SELECT S.StudentID, S.FullName, S.BirthDate, S.JoinDate, 
                             S.PhoneNumber, C.ClassName 
                             FROM Students S
                             LEFT JOIN Classes C ON S.ClassID = C.ClassID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ أثناء تحميل بيانات الطلاب: " + ex.Message);
                return null;
            }
        }

        public DataTable GetStudentById(int studentId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM Students WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.ExecuteNonQuery(); // ينفذ الأمر
                }
            }
        }


        public bool UpdateStudent(int studentId, Students student)
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = @"UPDATE Students 
                             SET FullName = @FullName,
                                 BirthDate = @BirthDate,
                                 JoinDate = @JoinDate,
                                 ClassID = @ClassID,
                                 PhoneNumber = @PhoneNumber
                             WHERE StudentID = @StudentID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@BirthDate", student.BirthDate);
                    cmd.Parameters.AddWithValue("@JoinDate", student.JoinDate);
                    cmd.Parameters.AddWithValue("@ClassID", student.ClassID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ أثناء تعديل الطالب: " + ex.Message);
                return false;
            }
        }




    }
}
