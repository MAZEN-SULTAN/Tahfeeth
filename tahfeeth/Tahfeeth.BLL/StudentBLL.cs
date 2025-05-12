using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahfeeth.DAL;




namespace Tahfeeth.BLL
{
    public class StudentBLL
    {
        private StudentDAL studentDal = new StudentDAL();

        public bool AddStudent(string fullName, DateTime birthDate, DateTime enrollDate, int classId)
        {
            return studentDal.AddStudent(fullName, birthDate, enrollDate, classId);
        }
    }
}