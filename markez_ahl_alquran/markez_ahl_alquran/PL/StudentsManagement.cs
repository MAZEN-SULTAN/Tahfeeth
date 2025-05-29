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
    public partial class StudentsManagement : Form
    {
        public StudentsManagement()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudents form = new AddStudents();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents(); // إعادة تحميل البيانات بعد الإضافة
            }
        }
    }
}
