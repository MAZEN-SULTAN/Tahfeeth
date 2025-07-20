using markez_ahl_alquran.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace markez_ahl_alquran.BL
{
    internal class StudentMonthlyReportBL
    {
        private readonly StudentMonthlyReportDAL dal;

        public StudentMonthlyReportBL()
        {
            dal = new StudentMonthlyReportDAL();
        }

        /// <summary>
        /// يجمع بيانات التقرير الشهري لطالب معين:
        /// - اسم الطالب والحلقة
        /// - بيانات الحفظ والمراجعة لشهر/سنة محددين
        /// - بيانات الحضور والغياب والملاحظات
        /// يعيد DataTable جاهز للاستهلال في Crystal Report.
        /// </summary>
        public DataTable GetStudentMonthlyData(int studentId, int month, int year)
        {
            return dal.GetStudentMonthlyData(studentId, month, year);
        }

    }
}
