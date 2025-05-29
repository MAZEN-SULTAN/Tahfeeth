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
using System.Globalization;
using markez_ahl_alquran.DAL;
using System.Data.SqlClient;
using markez_ahl_alquran.BL;


namespace markez_ahl_alquran.PL
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime birthDate = Age.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age))
                age--;

            lblCalculatedAge.Text = age.ToString();
            //DateTime birthDate = Age.Value;
            //int age = DateTime.Today.Year - birthDate.Year;

            //if (birthDate > DateTime.Today.AddYears(-age))
            //    age--; // تصحيح إذا لم يصل بعد إلى عيد ميلاده هذه السنة

            //MessageBox.Show("العمر هو: " + age + " سنة");


        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            LoadClasses();

            // ربط الحدث
            Age.ValueChanged += bunifuDatePicker1_ValueChanged;

            // حساب العمر أول مرة
            bunifuDatePicker1_ValueChanged(null, null);

            // CultureInfo culture = new CultureInfo("ar-US"); //  en-USأو "ar-EG" للعربية مع التقويم الميلادي
            // culture.DateTimeFormat.Calendar = new GregorianCalendar();

            // تعيين الثقافة بشكل مؤقت للعنصر فقط
            // System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            // System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            // الآن الـ DateTimePicker سيستخدم الميلادي
            // Age.Format = DateTimePickerFormat.Short;

        }

        private void LoadClasses()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (SqlConnection conn = db.GetConnection())
                {
                    string query = "SELECT ClassID, ClassName FROM Classes";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> classes = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        classes.Add((int)reader["ClassID"], reader["ClassName"].ToString());
                    }

                    CBClassID.DataSource = new BindingSource(classes, null);
                    CBClassID.DisplayMember = "Value";
                    CBClassID.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل الحلقات: " + ex.Message);
            }
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // قراءة البيانات من الواجهة
                string fullName = FullName.Text.Trim();
                string phoneNumber = StudentPhoneNumber.Text.Trim();

                int age;
                if (!int.TryParse(lblCalculatedAge.Text, out age))
                {
                    MessageBox.Show("❌ لم يتم احتساب العمر بشكل صحيح.");
                    return;
                }
                DateTime joinDate = JoinDate.Value;
                int classId = ((KeyValuePair<int, string>)CBClassID.SelectedItem).Key;

                // إنشاء كائن الطالب
                Students student = new Students
                {
                    FullName = fullName,
                    Age = age,
                    JoinDate = joinDate,
                    ClassID = classId,
                    PhoneNumber = phoneNumber
                };

                // حفظ البيانات
                StudentsDAL dal = new StudentsDAL();
                bool success = dal.InsertStudent(student);

                if (success)
                {
                    MessageBox.Show("✅ تم حفظ بيانات الطالب بنجاح.");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ أثناء حفظ البيانات: " + ex.Message);
            }
        }
        // دالة لتفريغ الحقول
        private void ClearForm()
        {
            FullName.Clear();
            Age.Value = DateTime.Today;
            JoinDate.Value = DateTime.Today;
            CBClassID.SelectedIndex = 0;
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
