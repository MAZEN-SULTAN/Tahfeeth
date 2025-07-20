using markez_ahl_alquran.BL;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace markez_ahl_alquran.PL
{
    public partial class MonthlyReportDetails : Form
    {
        private string printContent = string.Empty;

        private int studentId;
        private int month;
        private int year;
        private string studentName;

        public MonthlyReportDetails(int studentId, int month, int year)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.month = month;
            this.year = year;
            //this.studentName = studentName;
        }

        private void MonthlyReportDetails_Load(object sender, EventArgs e)
        {
            LoadStudentProgress();
            LoadAttendance();
            LoadNotes();
        }

        private void LoadStudentProgress()
        {
            StudentProgressBL bl = new StudentProgressBL();
            DataTable dt = bl.GetMonthlyProgress(studentId, month, year);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblHifz.Text = row["Hifz"].ToString();
                lblHifzEval.Text = row["HifzEval"].ToString();
                lblReview.Text = row["Review"].ToString();
                lblReviewEval.Text = row["ReviewEval"].ToString();
            }
        }

        private void LoadAttendance()
        {
            MonthlyReportBL bl = new MonthlyReportBL();
            DataTable dt = bl.GetMonthlyAttendance(studentId, month, year);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblPresent.Text = row["DaysPresent"].ToString();
                lblAbsentExcused.Text = row["ExcusedAbsences"].ToString();
                lblAbsentUnexcused.Text = row["UnexcusedAbsences"].ToString();
            }
        }

        private void LoadNotes()
        {
            MonthlyReportBL bl = new MonthlyReportBL();
            string notes = bl.GetMonthlyNotes(studentId, month, year);
            txtNotes.Text = notes;
        }

        // يمكن حذف الأحداث الفارغة التالية إن لم تكن مستخدمة
        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void PreparePrintContent()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("📌 تقرير شهري للطالب");
            sb.AppendLine("────────────────────────────");
            sb.AppendLine($"الطالب: {studentName}");
            sb.AppendLine($"الشهر: {month} / السنة: {year}");
            sb.AppendLine();
            sb.AppendLine("📖 الحفظ");
            sb.AppendLine($"من: {lblHifz.Text}");
            sb.AppendLine($"التقييم: {lblHifzEval.Text}");
            sb.AppendLine();
            sb.AppendLine("📚 المراجعة");
            sb.AppendLine($"من: {lblReview.Text}");
            sb.AppendLine($"التقييم: {lblReviewEval.Text}");
            sb.AppendLine();
            sb.AppendLine("🗓️ الحضور والغياب");
            sb.AppendLine($"أيام الحضور: {lblPresent.Text}");
            sb.AppendLine($"الغياب بعذر: {lblAbsentExcused.Text}");
            sb.AppendLine($"الغياب بدون عذر: {lblAbsentUnexcused.Text}");
            sb.AppendLine();
            sb.AppendLine("📝 ملاحظات المعلم:");
            sb.AppendLine(txtNotes.Text);

            printContent = sb.ToString();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            RectangleF layout = new RectangleF(100, 100, e.MarginBounds.Width, e.MarginBounds.Height);

            e.Graphics.DrawString(printContent, font, brush, layout);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PreparePrintContent();

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument printDoc = new PrintDocument();

            printDoc.PrintPage += printDocument1_PrintPage;
            previewDialog.Document = printDoc;

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            // 1. تجهيز المحتوى
            PreparePrintContent();

            // 2. إنشاء كائن الطباعة
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument printDoc = new PrintDocument();

            // 3. إرفاق الحدث الذي يرسم التقرير على الورقة
            printDoc.PrintPage += printDocument1_PrintPage;
            previewDialog.Document = printDoc;

            // 4. عرض معاينة للطباعة
            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print(); // تنفيذ الطباعة إذا وافق المستخدم
            }
        }
    }
}
