namespace CareerTide
{
    partial class VacancyGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacancyGUI));
            this.TopDockPB = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.aboutPB = new System.Windows.Forms.PictureBox();
            this.logOutPB = new System.Windows.Forms.PictureBox();
            this.employersPB = new System.Windows.Forms.PictureBox();
            this.jobsPB = new System.Windows.Forms.PictureBox();
            this.employeesPB = new System.Windows.Forms.PictureBox();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.newVacancyBtn = new System.Windows.Forms.Button();
            this.vacancyDGV = new System.Windows.Forms.DataGridView();
            this.noRoleLB = new System.Windows.Forms.Label();
            this.employerLB = new System.Windows.Forms.Label();
            this.adminLB = new System.Windows.Forms.Label();
            this.applicantLB = new System.Windows.Forms.Label();
            this.paymentUpdateBtn = new System.Windows.Forms.Button();
            this.unpaidCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopDockPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TopDockPB
            // 
            this.TopDockPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDockPB.Image = global::CareerTide.Properties.Resources.red_and_black_background;
            this.TopDockPB.Location = new System.Drawing.Point(0, 0);
            this.TopDockPB.Name = "TopDockPB";
            this.TopDockPB.Size = new System.Drawing.Size(1127, 57);
            this.TopDockPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopDockPB.TabIndex = 2;
            this.TopDockPB.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::CareerTide.Properties.Resources.red_and_black_background;
            this.pictureBox4.Location = new System.Drawing.Point(0, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 530);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // aboutPB
            // 
            this.aboutPB.Image = global::CareerTide.Properties.Resources.about;
            this.aboutPB.Location = new System.Drawing.Point(-1, 391);
            this.aboutPB.Name = "aboutPB";
            this.aboutPB.Size = new System.Drawing.Size(97, 97);
            this.aboutPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutPB.TabIndex = 20;
            this.aboutPB.TabStop = false;
            // 
            // logOutPB
            // 
            this.logOutPB.Image = global::CareerTide.Properties.Resources.log_out;
            this.logOutPB.Location = new System.Drawing.Point(-1, 488);
            this.logOutPB.Name = "logOutPB";
            this.logOutPB.Size = new System.Drawing.Size(97, 97);
            this.logOutPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutPB.TabIndex = 19;
            this.logOutPB.TabStop = false;
            // 
            // employersPB
            // 
            this.employersPB.Image = global::CareerTide.Properties.Resources.companies;
            this.employersPB.Location = new System.Drawing.Point(-1, 293);
            this.employersPB.Name = "employersPB";
            this.employersPB.Size = new System.Drawing.Size(97, 97);
            this.employersPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employersPB.TabIndex = 18;
            this.employersPB.TabStop = false;
            this.employersPB.Click += new System.EventHandler(this.employersPB_Click);
            // 
            // jobsPB
            // 
            this.jobsPB.Image = global::CareerTide.Properties.Resources.job_find;
            this.jobsPB.Location = new System.Drawing.Point(-1, 196);
            this.jobsPB.Name = "jobsPB";
            this.jobsPB.Size = new System.Drawing.Size(97, 97);
            this.jobsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jobsPB.TabIndex = 17;
            this.jobsPB.TabStop = false;
            // 
            // employeesPB
            // 
            this.employeesPB.Image = global::CareerTide.Properties.Resources.applications_employee;
            this.employeesPB.Location = new System.Drawing.Point(-1, 99);
            this.employeesPB.Name = "employeesPB";
            this.employeesPB.Size = new System.Drawing.Size(97, 97);
            this.employeesPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeesPB.TabIndex = 16;
            this.employeesPB.TabStop = false;
            // 
            // LogoPB
            // 
            this.LogoPB.Image = global::CareerTide.Properties.Resources.career_tide_logo;
            this.LogoPB.Location = new System.Drawing.Point(0, 0);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(97, 97);
            this.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPB.TabIndex = 15;
            this.LogoPB.TabStop = false;
            this.LogoPB.Click += new System.EventHandler(this.LogoPB_Click);
            // 
            // newVacancyBtn
            // 
            this.newVacancyBtn.Location = new System.Drawing.Point(991, 67);
            this.newVacancyBtn.Name = "newVacancyBtn";
            this.newVacancyBtn.Size = new System.Drawing.Size(124, 30);
            this.newVacancyBtn.TabIndex = 21;
            this.newVacancyBtn.Text = "New vacancy";
            this.newVacancyBtn.UseVisualStyleBackColor = true;
            this.newVacancyBtn.Click += new System.EventHandler(this.newVacancyBtn_Click);
            // 
            // vacancyDGV
            // 
            this.vacancyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vacancyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacancyDGV.Location = new System.Drawing.Point(107, 114);
            this.vacancyDGV.Name = "vacancyDGV";
            this.vacancyDGV.RowHeadersWidth = 51;
            this.vacancyDGV.RowTemplate.Height = 24;
            this.vacancyDGV.Size = new System.Drawing.Size(1008, 461);
            this.vacancyDGV.TabIndex = 22;
            // 
            // noRoleLB
            // 
            this.noRoleLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noRoleLB.AutoSize = true;
            this.noRoleLB.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRoleLB.Location = new System.Drawing.Point(122, 67);
            this.noRoleLB.Name = "noRoleLB";
            this.noRoleLB.Size = new System.Drawing.Size(337, 33);
            this.noRoleLB.TabIndex = 23;
            this.noRoleLB.Text = "Sign In to Start a Career";
            // 
            // employerLB
            // 
            this.employerLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employerLB.AutoSize = true;
            this.employerLB.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerLB.Location = new System.Drawing.Point(122, 67);
            this.employerLB.Name = "employerLB";
            this.employerLB.Size = new System.Drawing.Size(361, 33);
            this.employerLB.TabIndex = 24;
            this.employerLB.Text = "Here are your Vacancies: ";
            // 
            // adminLB
            // 
            this.adminLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminLB.AutoSize = true;
            this.adminLB.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLB.Location = new System.Drawing.Point(122, 67);
            this.adminLB.Name = "adminLB";
            this.adminLB.Size = new System.Drawing.Size(267, 33);
            this.adminLB.TabIndex = 25;
            this.adminLB.Text = "Manage Vacancies";
            // 
            // applicantLB
            // 
            this.applicantLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicantLB.AutoSize = true;
            this.applicantLB.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicantLB.Location = new System.Drawing.Point(122, 67);
            this.applicantLB.Name = "applicantLB";
            this.applicantLB.Size = new System.Drawing.Size(357, 33);
            this.applicantLB.TabIndex = 26;
            this.applicantLB.Text = "Start your dream job now";
            // 
            // paymentUpdateBtn
            // 
            this.paymentUpdateBtn.Location = new System.Drawing.Point(982, 68);
            this.paymentUpdateBtn.Name = "paymentUpdateBtn";
            this.paymentUpdateBtn.Size = new System.Drawing.Size(133, 29);
            this.paymentUpdateBtn.TabIndex = 27;
            this.paymentUpdateBtn.Text = "Payment Update";
            this.paymentUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // unpaidCB
            // 
            this.unpaidCB.AutoSize = true;
            this.unpaidCB.Location = new System.Drawing.Point(860, 73);
            this.unpaidCB.Name = "unpaidCB";
            this.unpaidCB.Size = new System.Drawing.Size(73, 20);
            this.unpaidCB.TabIndex = 28;
            this.unpaidCB.Text = "Unpaid";
            this.unpaidCB.UseVisualStyleBackColor = true;
            this.unpaidCB.CheckedChanged += new System.EventHandler(this.unpaidCB_CheckedChanged);
            // 
            // VacancyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 587);
            this.Controls.Add(this.unpaidCB);
            this.Controls.Add(this.paymentUpdateBtn);
            this.Controls.Add(this.applicantLB);
            this.Controls.Add(this.adminLB);
            this.Controls.Add(this.employerLB);
            this.Controls.Add(this.noRoleLB);
            this.Controls.Add(this.vacancyDGV);
            this.Controls.Add(this.newVacancyBtn);
            this.Controls.Add(this.aboutPB);
            this.Controls.Add(this.logOutPB);
            this.Controls.Add(this.employersPB);
            this.Controls.Add(this.jobsPB);
            this.Controls.Add(this.employeesPB);
            this.Controls.Add(this.LogoPB);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TopDockPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VacancyGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacancy";
            this.Load += new System.EventHandler(this.VacancyGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopDockPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopDockPB;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox aboutPB;
        private System.Windows.Forms.PictureBox logOutPB;
        private System.Windows.Forms.PictureBox employersPB;
        private System.Windows.Forms.PictureBox jobsPB;
        private System.Windows.Forms.PictureBox employeesPB;
        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.Button newVacancyBtn;
        private System.Windows.Forms.DataGridView vacancyDGV;
        private System.Windows.Forms.Label noRoleLB;
        private System.Windows.Forms.Label employerLB;
        private System.Windows.Forms.Label adminLB;
        private System.Windows.Forms.Label applicantLB;
        private System.Windows.Forms.Button paymentUpdateBtn;
        private System.Windows.Forms.CheckBox unpaidCB;
    }
}