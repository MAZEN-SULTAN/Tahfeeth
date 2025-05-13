using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tahfeeth.BLL;

namespace tahfeeth
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFullName.Text;
                DateTime birth = dtpBirthDat.Value;
                DateTime enroll = dtpEnrollDat.Value;
                int classId = Convert.ToInt32(cmbClasses.SelectedValue); // أو ComboBox إن وجد

                StudentBLL student = new StudentBLL();
                bool added = student.AddStudent(name, birth, enroll ,classId);

                if (added)
                    MessageBox.Show("تمت إضافة الطالب بنجاح");
                else
                    MessageBox.Show("فشلت عملية الإضافة");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }

        }

        private void txtClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
            
            
     

        private void AddStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=AIMAN-ALSHUJAA;Initial Catalog=TahfeethDB;Integrated Security=True;"))
            {
                string query = "SELECT ClassId, ClassName FROM Classes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbClasses.DataSource = dt;
                cmbClasses.DisplayMember = "ClassName";
                cmbClasses.ValueMember = "ClassId";
            }
        }

        private void texFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    




