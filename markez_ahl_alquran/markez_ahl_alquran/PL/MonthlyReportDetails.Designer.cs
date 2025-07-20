namespace markez_ahl_alquran.PL
{
    partial class MonthlyReportDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReportDetails));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.groupBoxNotes = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtNotes = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBoxAttendance = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblAbsentExcused = new System.Windows.Forms.Label();
            this.lblAbsentUnexcused = new System.Windows.Forms.Label();
            this.groupBoxProgress = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblReviewEval = new System.Windows.Forms.Label();
            this.lblHifz = new System.Windows.Forms.Label();
            this.lblHifzEval = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.groupBoxStudentInfo = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btnPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.groupBoxNotes.SuspendLayout();
            this.groupBoxAttendance.SuspendLayout();
            this.groupBoxProgress.SuspendLayout();
            this.groupBoxStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(638, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "تقرير شهري للطالب";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStudentName.Location = new System.Drawing.Point(1354, 36);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStudentName.Size = new System.Drawing.Size(64, 25);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "الاسم: ";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMonth.Location = new System.Drawing.Point(1352, 73);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMonth.Size = new System.Drawing.Size(66, 25);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "الشهر: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblYear.Location = new System.Drawing.Point(1354, 113);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYear.Size = new System.Drawing.Size(64, 25);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "السنة: ";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnPrint);
            this.bunifuPanel1.Controls.Add(this.groupBoxNotes);
            this.bunifuPanel1.Controls.Add(this.groupBoxAttendance);
            this.bunifuPanel1.Controls.Add(this.groupBoxProgress);
            this.bunifuPanel1.Controls.Add(this.groupBoxStudentInfo);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1483, 784);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // groupBoxNotes
            // 
            this.groupBoxNotes.BorderColor = System.Drawing.Color.LightGray;
            this.groupBoxNotes.BorderRadius = 1;
            this.groupBoxNotes.BorderThickness = 1;
            this.groupBoxNotes.Controls.Add(this.txtNotes);
            this.groupBoxNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxNotes.LabelAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.groupBoxNotes.LabelIndent = 10;
            this.groupBoxNotes.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.groupBoxNotes.Location = new System.Drawing.Point(3, 565);
            this.groupBoxNotes.Name = "groupBoxNotes";
            this.groupBoxNotes.Size = new System.Drawing.Size(1482, 105);
            this.groupBoxNotes.TabIndex = 6;
            this.groupBoxNotes.TabStop = false;
            this.groupBoxNotes.Text = "الملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = false;
            this.txtNotes.AcceptsTab = false;
            this.txtNotes.AnimationSpeed = 200;
            this.txtNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtNotes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNotes.BackgroundImage")));
            this.txtNotes.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNotes.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNotes.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNotes.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNotes.BorderRadius = 1;
            this.txtNotes.BorderThickness = 1;
            this.txtNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNotes.DefaultText = "";
            this.txtNotes.FillColor = System.Drawing.Color.White;
            this.txtNotes.HideSelection = true;
            this.txtNotes.IconLeft = null;
            this.txtNotes.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.IconPadding = 10;
            this.txtNotes.IconRight = null;
            this.txtNotes.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(1153, 35);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNotes.Modified = false;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNotes.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnIdleState = stateProperties4;
            this.txtNotes.Padding = new System.Windows.Forms.Padding(3);
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNotes.PlaceholderText = "اكتب ملاحظاتك هنا";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(260, 41);
            this.txtNotes.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNotes.TabIndex = 0;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNotes.TextMarginBottom = 0;
            this.txtNotes.TextMarginLeft = 3;
            this.txtNotes.TextMarginTop = 0;
            this.txtNotes.TextPlaceholder = "اكتب ملاحظاتك هنا";
            this.txtNotes.UseSystemPasswordChar = false;
            this.txtNotes.WordWrap = true;
            // 
            // groupBoxAttendance
            // 
            this.groupBoxAttendance.BorderColor = System.Drawing.Color.LightGray;
            this.groupBoxAttendance.BorderRadius = 1;
            this.groupBoxAttendance.BorderThickness = 1;
            this.groupBoxAttendance.Controls.Add(this.lblPresent);
            this.groupBoxAttendance.Controls.Add(this.lblAbsentExcused);
            this.groupBoxAttendance.Controls.Add(this.lblAbsentUnexcused);
            this.groupBoxAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxAttendance.LabelAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.groupBoxAttendance.LabelIndent = 10;
            this.groupBoxAttendance.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.groupBoxAttendance.Location = new System.Drawing.Point(3, 394);
            this.groupBoxAttendance.Name = "groupBoxAttendance";
            this.groupBoxAttendance.Size = new System.Drawing.Size(1482, 165);
            this.groupBoxAttendance.TabIndex = 5;
            this.groupBoxAttendance.TabStop = false;
            this.groupBoxAttendance.Text = "الحضور والغياب";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPresent.Location = new System.Drawing.Point(1306, 42);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPresent.Size = new System.Drawing.Size(112, 25);
            this.lblPresent.TabIndex = 1;
            this.lblPresent.Text = "أيام الحضور: ";
            // 
            // lblAbsentExcused
            // 
            this.lblAbsentExcused.AutoSize = true;
            this.lblAbsentExcused.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAbsentExcused.Location = new System.Drawing.Point(1318, 84);
            this.lblAbsentExcused.Name = "lblAbsentExcused";
            this.lblAbsentExcused.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAbsentExcused.Size = new System.Drawing.Size(100, 25);
            this.lblAbsentExcused.TabIndex = 2;
            this.lblAbsentExcused.Text = "غياب بعذر: ";
            this.lblAbsentExcused.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAbsentUnexcused
            // 
            this.lblAbsentUnexcused.AutoSize = true;
            this.lblAbsentUnexcused.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAbsentUnexcused.Location = new System.Drawing.Point(1280, 126);
            this.lblAbsentUnexcused.Name = "lblAbsentUnexcused";
            this.lblAbsentUnexcused.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAbsentUnexcused.Size = new System.Drawing.Size(138, 25);
            this.lblAbsentUnexcused.TabIndex = 3;
            this.lblAbsentUnexcused.Text = "غياب بدون عذر: ";
            // 
            // groupBoxProgress
            // 
            this.groupBoxProgress.BorderColor = System.Drawing.Color.LightGray;
            this.groupBoxProgress.BorderRadius = 1;
            this.groupBoxProgress.BorderThickness = 1;
            this.groupBoxProgress.Controls.Add(this.lblReviewEval);
            this.groupBoxProgress.Controls.Add(this.lblHifz);
            this.groupBoxProgress.Controls.Add(this.lblHifzEval);
            this.groupBoxProgress.Controls.Add(this.lblReview);
            this.groupBoxProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxProgress.LabelAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.groupBoxProgress.LabelIndent = 10;
            this.groupBoxProgress.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.groupBoxProgress.Location = new System.Drawing.Point(0, 183);
            this.groupBoxProgress.Name = "groupBoxProgress";
            this.groupBoxProgress.Size = new System.Drawing.Size(1480, 205);
            this.groupBoxProgress.TabIndex = 5;
            this.groupBoxProgress.TabStop = false;
            this.groupBoxProgress.Text = "الحفظ والمراجعة";
            // 
            // lblReviewEval
            // 
            this.lblReviewEval.AutoSize = true;
            this.lblReviewEval.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReviewEval.Location = new System.Drawing.Point(1291, 166);
            this.lblReviewEval.Name = "lblReviewEval";
            this.lblReviewEval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReviewEval.Size = new System.Drawing.Size(130, 25);
            this.lblReviewEval.TabIndex = 4;
            this.lblReviewEval.Text = "تقييم المراجعة: ";
            // 
            // lblHifz
            // 
            this.lblHifz.AutoSize = true;
            this.lblHifz.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHifz.Location = new System.Drawing.Point(1288, 39);
            this.lblHifz.Name = "lblHifz";
            this.lblHifz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHifz.Size = new System.Drawing.Size(133, 25);
            this.lblHifz.TabIndex = 1;
            this.lblHifz.Text = "تفاصيل الحفظ: ";
            // 
            // lblHifzEval
            // 
            this.lblHifzEval.AutoSize = true;
            this.lblHifzEval.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHifzEval.Location = new System.Drawing.Point(1308, 81);
            this.lblHifzEval.Name = "lblHifzEval";
            this.lblHifzEval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHifzEval.Size = new System.Drawing.Size(113, 25);
            this.lblHifzEval.TabIndex = 2;
            this.lblHifzEval.Text = "تقييم الحفظ: ";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReview.Location = new System.Drawing.Point(1271, 119);
            this.lblReview.Name = "lblReview";
            this.lblReview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReview.Size = new System.Drawing.Size(150, 25);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "تفاصيل المراجعة: ";
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.BorderColor = System.Drawing.Color.LightGray;
            this.groupBoxStudentInfo.BorderRadius = 1;
            this.groupBoxStudentInfo.BorderThickness = 1;
            this.groupBoxStudentInfo.Controls.Add(this.lblStudentName);
            this.groupBoxStudentInfo.Controls.Add(this.lblMonth);
            this.groupBoxStudentInfo.Controls.Add(this.lblYear);
            this.groupBoxStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxStudentInfo.LabelAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.groupBoxStudentInfo.LabelIndent = 10;
            this.groupBoxStudentInfo.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(3, 42);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(1482, 145);
            this.groupBoxStudentInfo.TabIndex = 4;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "معلومات الطالب";
            // 
            // btnPrint
            // 
            this.btnPrint.AllowAnimations = true;
            this.btnPrint.AllowMouseEffects = true;
            this.btnPrint.AllowToggling = false;
            this.btnPrint.AnimationSpeed = 200;
            this.btnPrint.AutoGenerateColors = false;
            this.btnPrint.AutoRoundBorders = false;
            this.btnPrint.AutoSizeLeftIcon = true;
            this.btnPrint.AutoSizeRightIcon = true;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.ButtonText = "طباعة التقرير";
            this.btnPrint.ButtonTextMarginLeft = 0;
            this.btnPrint.ColorContrastOnClick = 45;
            this.btnPrint.ColorContrastOnHover = 45;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPrint.CustomizableEdges = borderEdges1;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrint.IconMarginLeft = 11;
            this.btnPrint.IconPadding = 10;
            this.btnPrint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrint.IconSize = 25;
            this.btnPrint.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.IdleBorderRadius = 1;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.IdleIconLeftImage = null;
            this.btnPrint.IdleIconRightImage = null;
            this.btnPrint.IndicateFocus = false;
            this.btnPrint.Location = new System.Drawing.Point(1271, 686);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.OnDisabledState.BorderRadius = 1;
            this.btnPrint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnDisabledState.BorderThickness = 1;
            this.btnPrint.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.OnDisabledState.IconLeftImage = null;
            this.btnPrint.OnDisabledState.IconRightImage = null;
            this.btnPrint.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrint.onHoverState.BorderRadius = 1;
            this.btnPrint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.onHoverState.BorderThickness = 1;
            this.btnPrint.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.onHoverState.IconLeftImage = null;
            this.btnPrint.onHoverState.IconRightImage = null;
            this.btnPrint.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.OnIdleState.BorderRadius = 1;
            this.btnPrint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnIdleState.BorderThickness = 1;
            this.btnPrint.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnIdleState.IconLeftImage = null;
            this.btnPrint.OnIdleState.IconRightImage = null;
            this.btnPrint.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.BorderRadius = 1;
            this.btnPrint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnPressedState.BorderThickness = 1;
            this.btnPrint.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnPressedState.IconLeftImage = null;
            this.btnPrint.OnPressedState.IconRightImage = null;
            this.btnPrint.Size = new System.Drawing.Size(150, 39);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.TextMarginLeft = 0;
            this.btnPrint.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrint.UseDefaultRadiusAndThickness = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // MonthlyReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 784);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "MonthlyReportDetails";
            this.Text = "MonthlyReportDetails";
            this.Load += new System.EventHandler(this.MonthlyReportDetails_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.groupBoxNotes.ResumeLayout(false);
            this.groupBoxAttendance.ResumeLayout(false);
            this.groupBoxAttendance.PerformLayout();
            this.groupBoxProgress.ResumeLayout(false);
            this.groupBoxProgress.PerformLayout();
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuGroupBox groupBoxStudentInfo;
        private Bunifu.UI.WinForms.BunifuGroupBox groupBoxProgress;
        private System.Windows.Forms.Label lblReviewEval;
        private System.Windows.Forms.Label lblHifz;
        private System.Windows.Forms.Label lblHifzEval;
        private System.Windows.Forms.Label lblReview;
        private Bunifu.UI.WinForms.BunifuGroupBox groupBoxAttendance;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblAbsentExcused;
        private System.Windows.Forms.Label lblAbsentUnexcused;
        private Bunifu.UI.WinForms.BunifuGroupBox groupBoxNotes;
        private Bunifu.UI.WinForms.BunifuTextBox txtNotes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrint;
    }
}