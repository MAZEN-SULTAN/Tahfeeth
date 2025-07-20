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
        // خزن المعرّفات لكل حلقة وطالب
        private readonly Dictionary<string, int> classMap = new Dictionary<string, int>();
        private readonly Dictionary<string, int> studentMap = new Dictionary<string, int>();

        public ReportsMainForm()
        {
            InitializeComponent();
            InitializeReportTypes();
            grpMonthlyReport.Visible = false;
            //grpAdmin.Visible = false;
        }

        private void ReportsMainForm_Load(object sender, EventArgs e)
        {
            grpMonthlyReport.Visible = false;

            // ✅ الربط اليدوي للحدث (إذا لم يتم من المصمم)
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
        }


        //private void btnTest_Click(object sender, EventArgs e)
        //{
        //    grpMonthlyReport.Visible = true;
        //}

        // تعبئة قائمة أنواع التقارير
        private void InitializeReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("تقرير شهري للطالب");
            cmbReportType.Items.Add("تقرير إداري ومالي");
            cmbReportType.SelectedIndex = 0;

            // 🔧 استدعاء الحدث يدويًا
            cmbReportType_SelectedIndexChanged(cmbReportType, EventArgs.Empty);
        }


        // عند تغيير نوع التقرير
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem != null && cmbReportType.SelectedItem.ToString() == "تقرير شهري للطلاب")
            {
                // إظهار لوحة إعداد التقرير الشهري
                grpMonthlyReport.Visible = true;

                // تحميل البيانات إلى الحقول
                LoadMonthlyControls();
            }
            else
            {
                // إخفاء الحقول في حال نوع تقرير آخر
                grpMonthlyReport.Visible = false;
            }
        }



        // تهيئة عناصر تقرير الطلاب الشهري
        private void LoadMonthlyControls()
        {
            // حلقة
            classMap.Clear();
            cmbClass.Items.Clear();
            var classDal = new ClassDAL();
            DataTable dtClasses = classDal.GetAllClasses();
            foreach (DataRow r in dtClasses.Rows)
            {
                string name = r["ClassName"].ToString();
                int id = Convert.ToInt32(r["ClassID"]);
                cmbClass.Items.Add(name);
                classMap[name] = id;
            }

            // خامسة: الطلاب يرتبط بالحلقة
            cmbStudent.Items.Clear();
            studentMap.Clear();

            // الأشهر
            cmbMonth.Items.Clear();
            var cul = new CultureInfo("ar-SA");
            cul.DateTimeFormat.Calendar = new GregorianCalendar();
            cmbMonth.Items.AddRange(cul.DateTimeFormat.MonthNames.Where(m => !string.IsNullOrEmpty(m)).ToArray());
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            // السنة
            int cur = DateTime.Now.Year;
            numYear.Minimum = cur - 2;
            numYear.Maximum = cur + 1;
            numYear.Value = cur;
        }

        // عند اختيار الحلقة لتحميل طلابها
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.Items.Clear();
            studentMap.Clear();
            if (cmbClass.SelectedIndex < 0) return;
            int cid = classMap[cmbClass.SelectedItem.ToString()];
            var studentDal = new StudentsDAL();
            DataTable dtStudents = studentDal.GetStudentsByClass(cid);
            foreach (DataRow r in dtStudents.Rows)
            {
                string name = r["FullName"].ToString();
                int id = Convert.ToInt32(r["StudentID"]);
                cmbStudent.Items.Add(name);
                studentMap[name] = id;
            }
        }

        // زر عرض التقرير الشهري
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

            // تأكد أن التقرير لديه نفس أسماء الأعمدة الموجودة في dt

            using (var viewerForm = new Form())
            {
                ReportDocument rpt = new ReportDocument(); // استخدم ReportDocument
                string reportPath = Path.Combine(Application.StartupPath, "StudentMonthlyReport.rpt");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("لم يتم العثور على ملف التقرير.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rpt.Load(reportPath); // تحميل التقرير
                rpt.SetDataSource(dt); // ربط مصدر البيانات

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

        // زر تصدير التقرير الشهري (PDF/Word)
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

                string path = dlg.FileName;

                ReportDocument rpt = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "StudentMonthlyReport.rpt");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("لم يتم العثور على ملف التقرير.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rpt.Load(reportPath); // تحميل التقرير
                rpt.SetDataSource(dt); // ربط البيانات

                if (dlg.FilterIndex == 1)
                {
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
                }
                else
                {
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
                }

                MessageBox.Show("تم التصدير بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
