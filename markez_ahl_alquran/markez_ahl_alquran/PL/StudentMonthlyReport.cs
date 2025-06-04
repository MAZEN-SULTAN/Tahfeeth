using markez_ahl_alquran.DAL;
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
    public partial class StudentMonthlyReport : Form
    {
        Dictionary<string, int> studentMap = new Dictionary<string, int>();

        public StudentMonthlyReport()
        {
            InitializeComponent();
        }

        private void StudentMonthlyReport_Load(object sender, EventArgs e)
        {
            // تعبئة قائمة الطلاب
            StudentsDAL studentsDAL = new StudentsDAL();
            DataTable dt = studentsDAL.GetAllStudents();

            cmbStudents.Items.Clear();
            studentMap.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["FullName"].ToString();
                int id = Convert.ToInt32(row["StudentID"]);

                cmbStudents.Items.Add(name);
                studentMap[name] = id;
            }

            // تعبئة الأشهر
            cmbMonth.Items.AddRange(new string[]
            {
                "يناير", "فبراير", "مارس", "أبريل", "مايو", "يونيو",
                "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"
            });

            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            txtYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex == -1 || cmbMonth.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("يرجى اختيار الطالب، الشهر، وإدخال السنة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentName = cmbStudents.SelectedItem.ToString();
            int studentId = studentMap[studentName];
            int month = cmbMonth.SelectedIndex + 1;
            int year = Convert.ToInt32(txtYear.Text);

            // فتح نافذة التقرير التفصيلي وتمرير البيانات إليها
            MonthlyReportDetails reportForm = new MonthlyReportDetails(studentId, studentName, month, year);
            reportForm.ShowDialog();
        }
    }
}
