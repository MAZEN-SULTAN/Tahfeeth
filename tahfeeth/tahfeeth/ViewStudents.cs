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

namespace tahfeeth
{
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=AIMAN-ALSHUJAA;Initial Catalog=TahfeethDB;Integrated Security=True;"))
            {
                string query = "SELECT StudentId, FullName, BirthDate, EnrollDate, ClassId FROM Students";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvStudents.DataSource = dt;
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

