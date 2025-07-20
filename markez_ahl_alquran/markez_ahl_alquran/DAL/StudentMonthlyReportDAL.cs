using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace markez_ahl_alquran.DAL
{
    internal class StudentMonthlyReportDAL
    {
        private readonly DatabaseHelper db = new DatabaseHelper();

        /// <summary>
        /// يجلب كل بيانات الطالب للتقرير الشهري: معلومات الطالب، الحلقة،
        /// بيانات الحفظ والمراجعة للتقدم المسجّل في هذا الشهر، 
        /// وبيانات الحضور والغياب والملاحظات.
        /// </summary>
        public DataTable GetStudentMonthlyData(int studentId, int month, int year)
        {
            var dt = new DataTable();
            using (var conn = db.GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
SELECT 
    S.StudentID,
    S.FullName,
    C.ClassName,
    -- بيانات الحفظ
    SP.MemorizedFrom   AS HifzFrom,
    SP.MemorizedTo     AS HifzTo,
    SP.MemorizedEvaluation AS HifzEvaluation,
    -- بيانات المراجعة
    SP.ReviewedFrom    AS ReviewFrom,
    SP.ReviewedTo      AS ReviewTo,
    SP.ReviewedEvaluation  AS ReviewEvaluation,
    -- بيانات الحضور والغياب
    MR.DaysPresent,
    MR.ExcusedAbsences,
    MR.UnexcusedAbsences,
    MR.Notes
FROM Students S
INNER JOIN Classes C 
    ON S.ClassID = C.ClassID
LEFT JOIN StudentProgress SP 
    ON SP.StudentID = S.StudentID 
   AND MONTH(SP.RecordDate) = @month 
   AND YEAR(SP.RecordDate)  = @year
LEFT JOIN MonthlyReport MR 
    ON MR.StudentID = S.StudentID 
   AND MR.Month = @month 
   AND MR.Year  = @year
WHERE S.StudentID = @studentId;";

                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
