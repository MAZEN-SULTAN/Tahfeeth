using System;
using System.Data;
using markez_ahl_alquran.DAL;

namespace markez_ahl_alquran.BL
{
    public class MonthlyReportBL
    {
        private readonly MonthlyReportDAL dal;

        public MonthlyReportBL()
        {
            dal = new MonthlyReportDAL();
        }

        // دالة إضافة التقرير الشهري
        public bool AddMonthlyReport(int studentId, int month, int year, int daysPresent, int excused, int unexcused, string notes)
        {
            return dal.AddMonthlyReport(studentId, month, year, daysPresent, excused, unexcused, notes);
        }

        // دالة جلب الحضور والغياب
        public DataTable GetMonthlyAttendance(int studentId, int month, int year)
        {
            return dal.GetMonthlyAttendance(studentId, month, year);
        }

        // دالة جلب الملاحظات الشهرية
        public string GetMonthlyNotes(int studentId, int month, int year)
        {
            return dal.GetMonthlyNotes(studentId, month, year);
        }
    }
}
