namespace markez_ahl_alquran.PL
{
    partial class ReportsMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsMainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMonthlyReport = new System.Windows.Forms.GroupBox();
            this.btnExportMonthly = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnShowMonthly = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.grpMonthlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.DisplayMember = "تقرير شهري";
            this.cmbReportType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "تقرير شهري ",
            "تقرير مالي",
            "تقرير إداري ",
            "إصدار شهادة"});
            this.cmbReportType.Location = new System.Drawing.Point(415, 100);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReportType.Size = new System.Drawing.Size(243, 29);
            this.cmbReportType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(690, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "نوع التقرير";
            // 
            // grpMonthlyReport
            // 
            this.grpMonthlyReport.Controls.Add(this.btnExportMonthly);
            this.grpMonthlyReport.Controls.Add(this.btnShowMonthly);
            this.grpMonthlyReport.Controls.Add(this.numYear);
            this.grpMonthlyReport.Controls.Add(this.label5);
            this.grpMonthlyReport.Controls.Add(this.label4);
            this.grpMonthlyReport.Controls.Add(this.cmbMonth);
            this.grpMonthlyReport.Controls.Add(this.label3);
            this.grpMonthlyReport.Controls.Add(this.cmbStudent);
            this.grpMonthlyReport.Controls.Add(this.label2);
            this.grpMonthlyReport.Controls.Add(this.cmbClass);
            this.grpMonthlyReport.Location = new System.Drawing.Point(282, 162);
            this.grpMonthlyReport.Name = "grpMonthlyReport";
            this.grpMonthlyReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpMonthlyReport.Size = new System.Drawing.Size(501, 376);
            this.grpMonthlyReport.TabIndex = 2;
            this.grpMonthlyReport.TabStop = false;
            this.grpMonthlyReport.Text = "معلومات التقرير";
            this.grpMonthlyReport.Visible = false;
            // 
            // btnExportMonthly
            // 
            this.btnExportMonthly.AllowAnimations = true;
            this.btnExportMonthly.AllowMouseEffects = true;
            this.btnExportMonthly.AllowToggling = false;
            this.btnExportMonthly.AnimationSpeed = 200;
            this.btnExportMonthly.AutoGenerateColors = false;
            this.btnExportMonthly.AutoRoundBorders = false;
            this.btnExportMonthly.AutoSizeLeftIcon = true;
            this.btnExportMonthly.AutoSizeRightIcon = true;
            this.btnExportMonthly.BackColor = System.Drawing.Color.Transparent;
            this.btnExportMonthly.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnExportMonthly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportMonthly.BackgroundImage")));
            this.btnExportMonthly.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportMonthly.ButtonText = "تصدير";
            this.btnExportMonthly.ButtonTextMarginLeft = 0;
            this.btnExportMonthly.ColorContrastOnClick = 45;
            this.btnExportMonthly.ColorContrastOnHover = 45;
            this.btnExportMonthly.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnExportMonthly.CustomizableEdges = borderEdges9;
            this.btnExportMonthly.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportMonthly.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportMonthly.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportMonthly.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportMonthly.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExportMonthly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportMonthly.ForeColor = System.Drawing.Color.White;
            this.btnExportMonthly.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportMonthly.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportMonthly.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExportMonthly.IconMarginLeft = 11;
            this.btnExportMonthly.IconPadding = 10;
            this.btnExportMonthly.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportMonthly.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportMonthly.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExportMonthly.IconSize = 25;
            this.btnExportMonthly.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportMonthly.IdleBorderRadius = 1;
            this.btnExportMonthly.IdleBorderThickness = 1;
            this.btnExportMonthly.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnExportMonthly.IdleIconLeftImage = null;
            this.btnExportMonthly.IdleIconRightImage = null;
            this.btnExportMonthly.IndicateFocus = false;
            this.btnExportMonthly.Location = new System.Drawing.Point(79, 300);
            this.btnExportMonthly.Name = "btnExportMonthly";
            this.btnExportMonthly.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExportMonthly.OnDisabledState.BorderRadius = 1;
            this.btnExportMonthly.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportMonthly.OnDisabledState.BorderThickness = 1;
            this.btnExportMonthly.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExportMonthly.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExportMonthly.OnDisabledState.IconLeftImage = null;
            this.btnExportMonthly.OnDisabledState.IconRightImage = null;
            this.btnExportMonthly.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExportMonthly.onHoverState.BorderRadius = 1;
            this.btnExportMonthly.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportMonthly.onHoverState.BorderThickness = 1;
            this.btnExportMonthly.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExportMonthly.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExportMonthly.onHoverState.IconLeftImage = null;
            this.btnExportMonthly.onHoverState.IconRightImage = null;
            this.btnExportMonthly.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportMonthly.OnIdleState.BorderRadius = 1;
            this.btnExportMonthly.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportMonthly.OnIdleState.BorderThickness = 1;
            this.btnExportMonthly.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExportMonthly.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExportMonthly.OnIdleState.IconLeftImage = null;
            this.btnExportMonthly.OnIdleState.IconRightImage = null;
            this.btnExportMonthly.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportMonthly.OnPressedState.BorderRadius = 1;
            this.btnExportMonthly.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExportMonthly.OnPressedState.BorderThickness = 1;
            this.btnExportMonthly.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExportMonthly.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExportMonthly.OnPressedState.IconLeftImage = null;
            this.btnExportMonthly.OnPressedState.IconRightImage = null;
            this.btnExportMonthly.Size = new System.Drawing.Size(150, 39);
            this.btnExportMonthly.TabIndex = 11;
            this.btnExportMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportMonthly.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportMonthly.TextMarginLeft = 0;
            this.btnExportMonthly.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExportMonthly.UseDefaultRadiusAndThickness = true;
            // 
            // btnShowMonthly
            // 
            this.btnShowMonthly.AllowAnimations = true;
            this.btnShowMonthly.AllowMouseEffects = true;
            this.btnShowMonthly.AllowToggling = false;
            this.btnShowMonthly.AnimationSpeed = 200;
            this.btnShowMonthly.AutoGenerateColors = false;
            this.btnShowMonthly.AutoRoundBorders = false;
            this.btnShowMonthly.AutoSizeLeftIcon = true;
            this.btnShowMonthly.AutoSizeRightIcon = true;
            this.btnShowMonthly.BackColor = System.Drawing.Color.Transparent;
            this.btnShowMonthly.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnShowMonthly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowMonthly.BackgroundImage")));
            this.btnShowMonthly.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShowMonthly.ButtonText = "عرض التقرير";
            this.btnShowMonthly.ButtonTextMarginLeft = 0;
            this.btnShowMonthly.ColorContrastOnClick = 45;
            this.btnShowMonthly.ColorContrastOnHover = 45;
            this.btnShowMonthly.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnShowMonthly.CustomizableEdges = borderEdges10;
            this.btnShowMonthly.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowMonthly.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnShowMonthly.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnShowMonthly.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnShowMonthly.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnShowMonthly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowMonthly.ForeColor = System.Drawing.Color.White;
            this.btnShowMonthly.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMonthly.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnShowMonthly.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnShowMonthly.IconMarginLeft = 11;
            this.btnShowMonthly.IconPadding = 10;
            this.btnShowMonthly.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowMonthly.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnShowMonthly.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnShowMonthly.IconSize = 25;
            this.btnShowMonthly.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnShowMonthly.IdleBorderRadius = 1;
            this.btnShowMonthly.IdleBorderThickness = 1;
            this.btnShowMonthly.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnShowMonthly.IdleIconLeftImage = null;
            this.btnShowMonthly.IdleIconRightImage = null;
            this.btnShowMonthly.IndicateFocus = false;
            this.btnShowMonthly.Location = new System.Drawing.Point(298, 300);
            this.btnShowMonthly.Name = "btnShowMonthly";
            this.btnShowMonthly.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnShowMonthly.OnDisabledState.BorderRadius = 1;
            this.btnShowMonthly.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShowMonthly.OnDisabledState.BorderThickness = 1;
            this.btnShowMonthly.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnShowMonthly.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnShowMonthly.OnDisabledState.IconLeftImage = null;
            this.btnShowMonthly.OnDisabledState.IconRightImage = null;
            this.btnShowMonthly.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnShowMonthly.onHoverState.BorderRadius = 1;
            this.btnShowMonthly.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShowMonthly.onHoverState.BorderThickness = 1;
            this.btnShowMonthly.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnShowMonthly.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnShowMonthly.onHoverState.IconLeftImage = null;
            this.btnShowMonthly.onHoverState.IconRightImage = null;
            this.btnShowMonthly.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnShowMonthly.OnIdleState.BorderRadius = 1;
            this.btnShowMonthly.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShowMonthly.OnIdleState.BorderThickness = 1;
            this.btnShowMonthly.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnShowMonthly.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnShowMonthly.OnIdleState.IconLeftImage = null;
            this.btnShowMonthly.OnIdleState.IconRightImage = null;
            this.btnShowMonthly.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnShowMonthly.OnPressedState.BorderRadius = 1;
            this.btnShowMonthly.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShowMonthly.OnPressedState.BorderThickness = 1;
            this.btnShowMonthly.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnShowMonthly.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnShowMonthly.OnPressedState.IconLeftImage = null;
            this.btnShowMonthly.OnPressedState.IconRightImage = null;
            this.btnShowMonthly.Size = new System.Drawing.Size(150, 39);
            this.btnShowMonthly.TabIndex = 10;
            this.btnShowMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowMonthly.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowMonthly.TextMarginLeft = 0;
            this.btnShowMonthly.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnShowMonthly.UseDefaultRadiusAndThickness = true;
            this.btnShowMonthly.Click += new System.EventHandler(this.btnShowMonthly_Click);
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numYear.Location = new System.Drawing.Point(79, 211);
            this.numYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(186, 28);
            this.numYear.TabIndex = 9;
            this.numYear.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(298, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "السنة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(298, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "الشهر";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DisplayMember = "تقرير شهري";
            this.cmbMonth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "تقرير شهري ",
            "تقرير مالي",
            "تقرير إداري ",
            "إصدار شهادة"});
            this.cmbMonth.Location = new System.Drawing.Point(79, 143);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(187, 29);
            this.cmbMonth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(298, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم الطالب";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DisplayMember = "تقرير شهري";
            this.cmbStudent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Items.AddRange(new object[] {
            "تقرير شهري ",
            "تقرير مالي",
            "تقرير إداري ",
            "إصدار شهادة"});
            this.cmbStudent.Location = new System.Drawing.Point(79, 86);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(187, 29);
            this.cmbStudent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(298, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "الحلقة";
            // 
            // cmbClass
            // 
            this.cmbClass.DisplayMember = "تقرير شهري";
            this.cmbClass.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "تقرير شهري ",
            "تقرير مالي",
            "تقرير إداري ",
            "إصدار شهادة"});
            this.cmbClass.Location = new System.Drawing.Point(79, 23);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(187, 29);
            this.cmbClass.TabIndex = 2;
            // 
            // ReportsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 593);
            this.Controls.Add(this.grpMonthlyReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReportType);
            this.Name = "ReportsMainForm";
            this.Text = "ReportsMainForm";
            this.Load += new System.EventHandler(this.ReportsMainForm_Load);
            this.grpMonthlyReport.ResumeLayout(false);
            this.grpMonthlyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMonthlyReport;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportMonthly;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShowMonthly;
    }
}