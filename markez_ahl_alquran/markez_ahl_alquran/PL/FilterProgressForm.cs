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
    public partial class FilterProgressForm : Form
    {
        public FilterProgressForm()
        {
            InitializeComponent();
            LoadClasses();
            LoadYears();
            LoadMonths();
        }

        private void LoadClasses()
        {
            ClassDAL dal = new ClassDAL();
            comboBoxClass.DataSource = dal.GetAllClasses();
            comboBoxClass.DisplayMember = "ClassName";
            comboBoxClass.ValueMember = "ClassID";
        }

        private void LoadYears()
        {
            int currentYear = DateTime.Now.Year;

            DropDownYear.Minimum = currentYear - 2;
            DropDownYear.Maximum = currentYear + 1;
            DropDownYear.Value = currentYear;
        }

        /* private void LoadMonths()
         {
             comboBoxMonth.Items.AddRange(
                 System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
             );

             comboBoxMonth.SelectedIndex = DateTime.Now.Month - 1;
         }*/
        // داله تظهر الاشهر الميلادية في الفورم
        private void LoadMonths()
        {
            var gregorianCulture = new System.Globalization.CultureInfo("en-US");
            comboBoxMonth.Items.AddRange(gregorianCulture.DateTimeFormat.MonthNames
                .Where(month => !string.IsNullOrEmpty(month))
                .ToArray());

            comboBoxMonth.SelectedIndex = DateTime.Now.Month - 1;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex == -1 || comboBoxMonth.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى اختيار الحلقة والشهر والسنة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int classId = Convert.ToInt32(comboBoxClass.SelectedValue);
            int month = comboBoxMonth.SelectedIndex + 1;
            int year = Convert.ToInt32(DropDownYear.Value); // ✅ استخدام Value بدلاً من SelectedItem

            // فتح نموذج تسجيل التقدم
            var entryForm = new StudentProgressEntry(classId, month, year);
            entryForm.ShowDialog();
        }

        private void FilterProgressForm_Load(object sender, EventArgs e)
        {
            // يمكنك استخدام هذا الحدث لتهيئة إضافية عند تحميل الفورم إن لزم الأمر
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // هذا الحدث مخصص إذا أردت تنفيذ شيء عند تغيير السنة (اختياري)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
