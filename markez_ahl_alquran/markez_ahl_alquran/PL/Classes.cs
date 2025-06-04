using markez_ahl_alquran.BL;
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
    public partial class Classes : Form
    {
        private readonly ClassBL classBL = new ClassBL();
        public Classes()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClasses.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvClasses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClasses.EnableHeadersVisualStyles = false;
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            LoadClasses();
            LoadTeachers();
        }

        private void LoadClasses()
        {
            dgvClasses.DataSource = classBL.GetAllClasses();
        }

        private void LoadTeachers()
        {
            TeacherID.DataSource = classBL.GetAllTeachers();
            TeacherID.DisplayMember = "FullName";
            TeacherID.ValueMember = "TeacherID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ClassName.Text != "" && TeacherID.SelectedValue != null)
            {
                string name = ClassName.Text;
                int teacherID = (int)TeacherID.SelectedValue;

                classBL.AddClass(name, teacherID);
                LoadClasses();
                MessageBox.Show("تمت الإضافة بنجاح");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadClasses();
            LoadTeachers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                int classID = Convert.ToInt32(dgvClasses.CurrentRow.Cells["ClassID"].Value);
                classBL.DeleteClass(classID);
                LoadClasses();
                MessageBox.Show("تم الحذف بنجاح");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
