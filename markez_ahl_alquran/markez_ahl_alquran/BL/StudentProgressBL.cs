using markez_ahl_alquran.DAL;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace markez_ahl_alquran.BL
{
    public class StudentProgressBL
    {
        private readonly StudentProgressDAL dal;

        public StudentProgressBL()
        {
            dal = new StudentProgressDAL();
        }

        public DataTable GetMonthlyProgress(int studentId, int month, int year)
        {
            return dal.GetMonthlyProgress(studentId, month, year);
        }
    }
}
