using markez_ahl_alquran.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markez_ahl_alquran.BL
{
    public class ClassBL
    {
        private readonly ClassDAL classDAL = new ClassDAL();

        public DataTable GetAllClasses()
        {
            return classDAL.GetAllClasses();
        }

        public void AddClass(string className, int teacherID)
        {
            classDAL.AddClass(className, teacherID);
        }

        public void DeleteClass(int classID)
        {
            classDAL.DeleteClass(classID);
        }

        public DataTable GetAllTeachers()
        {
            return classDAL.GetAllTeachers();
        }
    }
}
