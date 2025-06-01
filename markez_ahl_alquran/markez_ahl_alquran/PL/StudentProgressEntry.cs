using markez_ahl_alquran.BL;
using markez_ahl_alquran.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markez_ahl_alquran.PL
{
    public partial class StudentProgressEntry : Form
    {

        private int _classId;
        private int _month;
        private int _year;

        public StudentProgressEntry(int classId, int month, int year)
        {
            InitializeComponent();

            _classId = classId;
            _month = month;
            _year = year;

            SetHeaderTitle();
            SetupDataGridView();
            LoadStudents();
        }

        // 1. إعداد العنوان
        private void SetHeaderTitle()
        {
            // جلب اسم الحلقة من DAL
            ClassDAL dal = new ClassDAL();
            string className = dal.GetClassNameById(_classId); // تأكد أن هذه الدالة موجودة في DAL

            // جلب اسم الشهر
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_month);

            // تكوين العنوان
            lblTitle.Text = $"تسجيل تقدم الطلاب - حلقة: {className} - شهر: {monthName} - سنة: {_year}";
        }

        // 2. إعداد أعمدة DataGridView يدويًا
        private void SetupDataGridView()
        {
            dataGridViewProgress.Columns.Clear();
            dataGridViewProgress.AutoGenerateColumns = false;
            dataGridViewProgress.AllowUserToAddRows = false;
            dataGridViewProgress.RightToLeft = RightToLeft.Yes;
            dataGridViewProgress.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // رقم الطالب (مخفي)
            DataGridViewTextBoxColumn colStudentID = new DataGridViewTextBoxColumn();
            colStudentID.Name = "StudentID";
            colStudentID.DataPropertyName = "StudentID";
            colStudentID.Visible = false;
            colStudentID.ReadOnly = true;
            dataGridViewProgress.Columns.Add(colStudentID);

            // اسم الطالب
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "FullName";
            colName.HeaderText = "اسم الطالب";
            colName.DataPropertyName = "FullName";
            colName.Width = 230;
            colName.ReadOnly = true;
            dataGridViewProgress.Columns.Add(colName);

            // من آية ... إلى آية
            dataGridViewProgress.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "من الحفظ", Name = "MemorizedFrom", Width = 230 });
            dataGridViewProgress.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "إلى ", Name = "MemorizedTo", Width = 230 });

            // مراجعة من ... إلى
            dataGridViewProgress.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "مراجعة من", Name = "ReviewedFrom", Width = 230 });
            dataGridViewProgress.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "إلى", Name = "ReviewedTo", Width = 230 });
        }



        // 3. تحميل الطلاب في الحلقة
        private void LoadStudents()
        {
            StudentsDAL dal = new StudentsDAL();
            DataTable dt = dal.GetStudentsByClass(_classId);
            dataGridViewProgress.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dataGridViewProgress.Rows.Add();
                dataGridViewProgress.Rows[rowIndex].Cells["StudentID"].Value = row["StudentID"];
                dataGridViewProgress.Rows[rowIndex].Cells["FullName"].Value = row["FullName"];
            }
        }
        public StudentProgressEntry()
        {
            InitializeComponent();
        }

        private void StudentProgressEntry_Load(object sender, EventArgs e)
        {

        }
        private void LoadStudentsProgress()
        {
            SetupDataGridView(); // تأكد من إنشاء الأعمدة
            StudentsDAL studentDAL = new StudentsDAL();
            DataTable students = studentDAL.GetStudentsByClass(_classId);

            foreach (DataRow row in students.Rows)
            {
                dataGridViewProgress.Rows.Add(
                    row["StudentID"],
                    row["FullName"],
                    "", "", "", "" // الخانات القابلة للإدخال
                );
            }
        }

        // زر الحفظ
        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentProgressDAL progressDAL = new StudentProgressDAL();

            foreach (DataGridViewRow row in dataGridViewProgress.Rows)
            {
                int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                string memorizedFrom = row.Cells["MemorizedFrom"].Value?.ToString();
                string memorizedTo = row.Cells["MemorizedTo"].Value?.ToString();
                string reviewedFrom = row.Cells["ReviewedFrom"].Value?.ToString();
                string reviewedTo = row.Cells["ReviewedTo"].Value?.ToString();

                progressDAL.InsertStudentProgress(studentId, _year, _month, memorizedFrom, memorizedTo, reviewedFrom, reviewedTo);
            }

            MessageBox.Show("تم حفظ تقدم الطلاب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridViewProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
