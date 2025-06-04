using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using markez_ahl_alquran.BL;

namespace markez_ahl_alquran.PL
{
    public partial class Teachers : Form
    {
        TeacherBL teacherBL = new TeacherBL();

        public Teachers()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }
        private void LoadTeachers()
        {
            dgvTeacher.DataSource = teacherBL.GetAllTeachers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TeacherName.Text) || string.IsNullOrWhiteSpace(Salary.Text))
            {
                MessageBox.Show("الرجاء إدخال جميع البيانات");
                return;
            }

            string name = TeacherName.Text;
            if (!decimal.TryParse(Salary.Text, out decimal salary))
            {
                MessageBox.Show("الرجاء إدخال راتب صالح");
                return;
            }
            string phonenumber = TeacherName.Text;
            if (!decimal.TryParse(TeacherPhoneNumber.Text, out decimal Phonenumber))
            {
                MessageBox.Show("الرجاء إدخال راتب صالح");
                return;
            }

            try
            {
                teacherBL.AddTeacher(name, salary, Phonenumber);
                MessageBox.Show("تمت الإضافة بنجاح");
                LoadTeachers();
                TeacherName.Clear();
                Salary.Clear();
                TeacherPhoneNumber.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }

        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                int teacherID = Convert.ToInt32(dgvTeacher.SelectedRows[0].Cells["TeacherID"].Value);

                DialogResult result = MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        teacherBL.DeleteTeacher(teacherID);
                        MessageBox.Show("تم الحذف بنجاح");
                        LoadTeachers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ أثناء الحذف: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد المعلم المراد حذفه");
            }
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTeacher.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvTeacher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTeacher.EnableHeadersVisualStyles = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
