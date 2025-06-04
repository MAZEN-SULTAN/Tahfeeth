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
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }

        Dictionary<string, int> studentMap = new Dictionary<string, int>();
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            

            StudentsDAL studentsDAL = new StudentsDAL();
            DataTable dt = studentsDAL.GetAllStudents();

            cmbStudents.Items.Clear();
            studentMap.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["FullName"].ToString();
                int id = Convert.ToInt32(row["StudentID"]);

                cmbStudents.Items.Add(name); // نعرض الاسم فقط
                studentMap[name] = id;       // نربط الاسم بالـ ID في القاموس
            }

            // تعبئة الأشهر
            cmbMonth.Items.AddRange(new string[]
            {
        "يناير", "فبراير", "مارس", "أبريل", "مايو", "يونيو",
        "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"
            });
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            TextYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex == -1 || cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الطالب والشهر");
                return;
            }

            string selectedName = cmbStudents.SelectedItem.ToString();
            if (!studentMap.ContainsKey(selectedName))
            {
                MessageBox.Show("الطالب غير موجود في السجل");
                return;
            }

            int studentId = studentMap[selectedName];
            int month = cmbMonth.SelectedIndex + 1;

            if (!int.TryParse(TextYear.Text, out int year))
            {
                MessageBox.Show("يرجى إدخال سنة صحيحة");
                return;
            }

            if (!int.TryParse(TextPresentDays.Text, out int present) ||
       !int.TryParse(TextExcusedAbsences.Text, out int excused) ||
       !int.TryParse(TextUnexcusedAbsences.Text, out int unexcused))
            {
                MessageBox.Show("يرجى إدخال أرقام صحيحة لأيام الحضور والغياب");
                return;
            }



            string notes = TextNotes.Text;

            MonthlyReportDAL dal = new MonthlyReportDAL();
            bool result = dal.AddMonthlyReport(studentId, month, year, present, excused, unexcused, notes);

            if (result) { 
                MessageBox.Show("تم حفظ الحضور والغياب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
            else
                MessageBox.Show("حدث خطأ أثناء حفظ التقرير");
        }


        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TextAbsentDays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
