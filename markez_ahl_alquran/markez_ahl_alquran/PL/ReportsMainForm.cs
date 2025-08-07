using CrystalDecisions.CrystalReports.Engine;
using markez_ahl_alquran.BL;
using markez_ahl_alquran.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace markez_ahl_alquran.PL
{
    public partial class ReportsMainForm : Form
    {
        // قواميس لتخزين المعرفات
        private readonly Dictionary<string, int> classMap = new Dictionary<string, int>();
        private readonly Dictionary<string, int> studentMap = new Dictionary<string, int>();

        public ReportsMainForm()
        {
            InitializeComponent();
            InitializeReportTypes();
            grpMonthlyReport.Visible = false;
        }

        private void ReportsMainForm_Load(object sender, EventArgs e)
        {
            // إخفاء المجموعة عند البداية
            grpMonthlyReport.Visible = false;

            // ربط الأحداث يدوياً لضمان عملها
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;

            // تحميل أنواع التقارير
            InitializeReportTypes();
        }

        // تعبئة قائمة أنواع التقارير
        private void InitializeReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("تقرير شهري للطالب"); // index 0
            cmbReportType.Items.Add("تقرير إداري ومالي"); // index 1
            cmbReportType.SelectedIndex = -1; // 🔹 لا يوجد اختيار افتراضي
        }

        // عند تغيير نوع التقرير
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem != null && cmbReportType.SelectedItem.ToString() == "تقرير شهري للطالب")
            {
                grpMonthlyReport.Visible = true;
                LoadMonthlyControls();
            }
            else
            {
                grpMonthlyReport.Visible = false;
            }
        }

        // تحميل بيانات التقرير الشهري
        private void LoadMonthlyControls()
        {
            // تحميل الحلقاتبان التقرير غير موجود
            classMap.Clear();
            cmbClass.Items.Clear();
            DataTable dtClasses = new ClassDAL().GetAllClasses();
            foreach (DataRow r in dtClasses.Rows)
            {
                string name = r["ClassName"].ToString();
                int id = Convert.ToInt32(r["ClassID"]);
                cmbClass.Items.Add(name);
                classMap[name] = id;
            }
            MessageBox.Show($"تم تحميل {dtClasses.Rows.Count} حلقة من قاعدة البيانات");

            // تصفير الطلاب
            cmbStudent.Items.Clear();
            studentMap.Clear();

            // الأشهر
            cmbMonth.Items.Clear();
            var cul = new CultureInfo("ar-SA");
            cul.DateTimeFormat.Calendar = new GregorianCalendar();
            cmbMonth.Items.AddRange(cul.DateTimeFormat.MonthNames.Where(m => !string.IsNullOrEmpty(m)).ToArray());
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            // السنة
            int curYear = DateTime.Now.Year;
            numYear.Minimum = curYear - 2;
            numYear.Maximum = curYear + 1;
            numYear.Value = curYear;
        }

        // عند اختيار الحلقة تحميل الطلاب
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.Items.Clear();
            studentMap.Clear();

            if (cmbClass.SelectedIndex < 0) return;

            string selectedClass = cmbClass.SelectedItem.ToString();
            MessageBox.Show($"تم اختيار الحلقة: {selectedClass}");

            if (!classMap.ContainsKey(selectedClass))
            {
                MessageBox.Show("اسم الحلقة غير موجود في classMap");
                return;
            }

            int cid = classMap[selectedClass];
            var studentDal = new StudentsDAL();
            DataTable dtStudents = studentDal.GetStudentsByClass(cid);

            MessageBox.Show($"تم جلب {dtStudents.Rows.Count} طالب من قاعدة البيانات");

            foreach (DataRow r in dtStudents.Rows)
            {
                string name = r["FullName"].ToString();
                int id = Convert.ToInt32(r["StudentID"]);
                cmbStudent.Items.Add(name);
                studentMap[name] = id;
            }
        }


        // عرض التقرير
        private void btnShowMonthly_Click(object sender, EventArgs e)
        {
            
            if (cmbStudent.SelectedIndex < 0)
            {
                MessageBox.Show("يرجى اختيار الطالب لعرض التقرير.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sid = studentMap[cmbStudent.SelectedItem.ToString()];
            int mon = cmbMonth.SelectedIndex + 1;
            int yr = (int)numYear.Value;

            DataTable dt = new StudentMonthlyReportBL().GetStudentMonthlyData(sid, mon, yr);

            using (var viewerForm = new Form())
            {
                ReportDocument rpt = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "StudentMonthlyReport.rpt");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("لم يتم العثور على ملف التقرير.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rpt.Load(reportPath);
                rpt.SetDataSource(dt);

                var viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer
                {
                    Dock = DockStyle.Fill,
                    ReportSource = rpt
                };

                viewerForm.Controls.Add(viewer);
                viewerForm.WindowState = FormWindowState.Maximized;
                viewerForm.Text = "تقرير الطالب الشهري";
                viewerForm.ShowDialog();
            }
        }

        // تصدير التقرير
        private void btnExportMonthly_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex < 0)
            {
                MessageBox.Show("يرجى اختيار الطالب للتصدير.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sid = studentMap[cmbStudent.SelectedItem.ToString()];
            int mon = cmbMonth.SelectedIndex + 1;
            int yr = (int)numYear.Value;
            DataTable dt = new StudentMonthlyReportBL().GetStudentMonthlyData(sid, mon, yr);

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "PDF (*.pdf)|*.pdf|Word (*.docx)|*.docx";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                ReportDocument rpt = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "StudentMonthlyReport.rpt");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("لم يتم العثور على ملف التقرير.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rpt.Load(reportPath);
                rpt.SetDataSource(dt);

                if (dlg.FilterIndex == 1)
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dlg.FileName);
                else
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, dlg.FileName);

                MessageBox.Show("تم التصدير بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
