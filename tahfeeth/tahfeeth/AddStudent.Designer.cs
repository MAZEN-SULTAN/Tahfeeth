namespace tahfeeth
{
    partial class AddStudent
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
            this.txtFullName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.dtpEnrollDat = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDat = new System.Windows.Forms.DateTimePicker();
            this.texFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnrollDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Location = new System.Drawing.Point(647, 44);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(92, 17);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "الاسم الكامل :";
            this.txtFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbClasses);
            this.groupBox1.Controls.Add(this.dtpEnrollDat);
            this.groupBox1.Controls.Add(this.dtpBirthDat);
            this.groupBox1.Controls.Add(this.texFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEnrollDate);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Location = new System.Drawing.Point(27, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(748, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات طالب";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(443, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "إلغاء";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(558, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(443, 160);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(196, 24);
            this.cmbClasses.TabIndex = 4;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.txtClassId_SelectedIndexChanged);
            // 
            // dtpEnrollDat
            // 
            this.dtpEnrollDat.Location = new System.Drawing.Point(443, 119);
            this.dtpEnrollDat.Name = "dtpEnrollDat";
            this.dtpEnrollDat.Size = new System.Drawing.Size(196, 24);
            this.dtpEnrollDat.TabIndex = 3;
            // 
            // dtpBirthDat
            // 
            this.dtpBirthDat.Location = new System.Drawing.Point(443, 80);
            this.dtpBirthDat.Name = "dtpBirthDat";
            this.dtpBirthDat.Size = new System.Drawing.Size(197, 24);
            this.dtpBirthDat.TabIndex = 2;
            this.dtpBirthDat.Value = new System.DateTime(2025, 5, 11, 22, 59, 10, 0);
            // 
            // texFullName
            // 
            this.texFullName.Location = new System.Drawing.Point(443, 42);
            this.texFullName.Name = "texFullName";
            this.texFullName.Size = new System.Drawing.Size(198, 24);
            this.texFullName.TabIndex = 1;
            this.texFullName.TextChanged += new System.EventHandler(this.texFullName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "الحلقة :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpEnrollDate
            // 
            this.dtpEnrollDate.AutoSize = true;
            this.dtpEnrollDate.Location = new System.Drawing.Point(647, 123);
            this.dtpEnrollDate.Name = "dtpEnrollDate";
            this.dtpEnrollDate.Size = new System.Drawing.Size(100, 17);
            this.dtpEnrollDate.TabIndex = 0;
            this.dtpEnrollDate.Text = "تاريخ التسجيل :";
            this.dtpEnrollDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.AutoSize = true;
            this.dtpBirthDate.Location = new System.Drawing.Point(654, 82);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(86, 17);
            this.dtpBirthDate.TabIndex = 0;
            this.dtpBirthDate.Text = "تاريخ الميلاد :";
            this.dtpBirthDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texFullName;
        private System.Windows.Forms.Label dtpBirthDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.DateTimePicker dtpEnrollDat;
        private System.Windows.Forms.DateTimePicker dtpBirthDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dtpEnrollDate;
    }
}