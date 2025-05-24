using markez_ahl_alquran.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markez_ahl_alquran.DAL;

namespace markez_ahl_alquran.BL
{
    public class TeacherBL
    {
        private TeacherDAL dal = new TeacherDAL();

        public DataTable GetAllTeachers()
        {
            return dal.GetAllTeachers();
        }

        public void AddTeacher(string fullName, decimal salary)
        {
            dal.AddTeacher(fullName, salary);
        }

        public void DeleteTeacher(int teacherID)
        {
            dal.DeleteTeacher(teacherID);
        }
    }
}
