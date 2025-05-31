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
using markez_ahl_alquran.PL;

namespace markez_ahl_alquran.PL
{
    public partial class StudentsManagement : Form
    {
        public StudentsManagement()
        {
            InitializeComponent();
        }

        private void StudentsManagement_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            StudentsDAL dal = new StudentsDAL();
            DataTable dt = dal.GetAllStudents(); // استدعاء البيانات من DAL

            if (dt != null)
            {
                dataGridViewStudents.DataSource = null;
                dataGridViewStudents.Columns.Clear(); // إزالة الأعمدة القديمة مثل زر الحذف أو التعديل
                                                      //dataGridViewStudents.DataSource = dt;

                dataGridViewStudents.Columns.Add("StudentID", "رقم الطالب");
                dataGridViewStudents.Columns["StudentID"].Visible = false;
                dataGridViewStudents.Columns.Add("RowNumber", "رقم الطالب");
                dataGridViewStudents.Columns.Add("FullName", "اسم الطالب");
                dataGridViewStudents.Columns.Add("BirthDate", "تاريخ الميلاد");
                dataGridViewStudents.Columns.Add("Age", "العمر"); // سيتم حسابه
                dataGridViewStudents.Columns.Add("JoinDate", "تاريخ الانضمام");
                dataGridViewStudents.Columns.Add("PhoneNumber", "رقم الهاتف");
                dataGridViewStudents.Columns.Add("ClassName", "اسم الحلقة");

                // تعبئة الصفوف بالبيانات من DataTable
               // int rowNumber = 1;

                foreach (DataRow row in dt.Rows)
                {
                    // حساب العمر بناءً على تاريخ الميلاد
                    DateTime birthDate = Convert.ToDateTime(row["BirthDate"]);
                    int age = DateTime.Now.Year - birthDate.Year;
                    if (DateTime.Now < birthDate.AddYears(age)) age--; // تصحيح العمر إن لم يصل عيد ميلاده هذه السنة

                    // إضافة صف جديد للطالب
                    dataGridViewStudents.Rows.Add(
                     //   rowNumber++, // الرقم التسلسلي
                        row["StudentID"],
                        row["FullName"],
                        birthDate.ToShortDateString(), // عرض تاريخ الميلاد كـ نص
                        age, // العمر المحسوب
                        Convert.ToDateTime(row["JoinDate"]).ToShortDateString(),
                        row["PhoneNumber"],
                        row["ClassName"]
                    );
                }

                // إضافة عمود زر "تعديل" إن لم يكن موجود
                if (!dataGridViewStudents.Columns.Contains("EditColumn"))
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                    editColumn.Name = "EditColumn";
                    editColumn.HeaderText = "تعديل";
                    editColumn.Text = "✏️";
                    editColumn.UseColumnTextForButtonValue = true;
                    dataGridViewStudents.Columns.Add(editColumn);
                }

                // إضافة عمود زر "حذف" إن لم يكن موجود
                if (!dataGridViewStudents.Columns.Contains("DeleteColumn"))
                {
                    DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                    deleteColumn.Name = "DeleteColumn";
                    deleteColumn.HeaderText = "حذف";
                    deleteColumn.Text = "🗑️";
                    deleteColumn.UseColumnTextForButtonValue = true;
                    dataGridViewStudents.Columns.Add(deleteColumn);
                }

                // تحسين عرض الجدول (اختياري)
                dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }



        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudents form = new AddStudents();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents(); // إعادة تحميل البيانات بعد الإضافة
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                // عمود التعديل
                if (dataGridViewStudents.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int studentId = Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells["StudentID"].Value);
                //    // فتح نموذج التعديل
                AddStudents editForm = new AddStudents(studentId); // تمرير ID الطالب
                if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadStudents(); // إعادة تحميل البيانات بعد التعديل
            }
                }

                // عمود الحذف
                else if (dataGridViewStudents.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    DialogResult result = MessageBox.Show("هل تريد حذف هذا الطالب؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int studentId = Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells["StudentID"].Value);
                        StudentsDAL dal = new StudentsDAL();
                        dal.DeleteStudent(studentId);
                        LoadStudents(); // إعادة تحميل البيانات بعد الحذف
                    }
                }
            }

           

        }

        private void dataGridViewStudents_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewStudents.Rows[e.RowIndex].Cells["EditColumn"].Style.BackColor = Color.LightBlue;
                dataGridViewStudents.Rows[e.RowIndex].Cells["DeleteColumn"].Style.BackColor = Color.LightCoral;
            }
        }

        private void btnAddStudent_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
