using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markez_ahl_alquran.PL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            //AddStudents studentsForm = new AddStudents();
            //studentsForm.ShowDialog();

            //StudentsManagement form = new StudentsManagement();
            //form.ShowDialog();
            StudentsManagement studentsForm = new StudentsManagement();
            studentsForm.ShowDialog(); // عرض الواجهة بشكل منبثق
        }

        private void btnManageClasses_Click(object sender, EventArgs e)
        {
            Classes classesForm = new Classes();
            classesForm.ShowDialog();
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            Teachers teachersForm = new Teachers();
            teachersForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentProgressEntry_Click(object sender, EventArgs e)
        {
            FilterProgressForm filterProgress = new FilterProgressForm();
            filterProgress.ShowDialog(); // عرض الواجهة بشكل منبثق
        }

        private void btnStudentManagment(object sender, EventArgs e)
        {
            MonthlyReport AbsentManagment = new MonthlyReport();
            AbsentManagment.ShowDialog();
        }
    }
}
