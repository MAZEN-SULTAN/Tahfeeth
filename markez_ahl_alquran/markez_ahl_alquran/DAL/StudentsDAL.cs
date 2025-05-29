using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using markez_ahl_alquran.BL; // لأننا سنستخدم كائن الطالب Student
using System.Windows.Forms;

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
                    string query = "INSERT INTO Students (FullName, Age, JoinDate, ClassID, PhoneNumber) VALUES (@FullName, @Age, @JoinDate, @ClassID, @PhoneNumber)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // إضافة القيم
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@Age", student.Age);
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
    }
}
