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
            this.remainsTB = new System.Windows.Forms.TextBox();
            this.remainsLB = new System.Windows.Forms.Label();
            this.paymentUpdatePN = new System.Windows.Forms.Panel();
            this.companyNameLB = new System.Windows.Forms.Label();
            this.cpnNameTB = new System.Windows.Forms.TextBox();
            this.paymentHistoryDGV = new System.Windows.Forms.DataGridView();
            this.paymentHistoryLB = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.paidUpdateLB = new System.Windows.Forms.Label();
            this.paymentTypeCB = new System.Windows.Forms.ComboBox();
            this.paidTypeLB = new System.Windows.Forms.Label();
            this.cfBtn = new System.Windows.Forms.Button();
            this.updatePaymentFromCustomerLB = new System.Windows.Forms.Label();
            this.approveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopDockPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logOutPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyDGV)).BeginInit();
            this.paymentUpdatePN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDGV)).BeginInit();
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
            this.vacancyDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vacancyDGV.Size = new System.Drawing.Size(1008, 461);
            this.vacancyDGV.TabIndex = 22;
            this.vacancyDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vacancyDGV_CellClick);
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
            this.paymentUpdateBtn.Click += new System.EventHandler(this.paymentUpdateBtn_Click);
            // 
            // unpaidCB
            // 
            this.unpaidCB.AutoSize = true;
            this.unpaidCB.Location = new System.Drawing.Point(860, 73);
            this.unpaidCB.Name = "unpaidCB";
            this.unpaidCB.Size = new System.Drawing.Size(79, 20);
            this.unpaidCB.TabIndex = 28;
            this.unpaidCB.Text = "Pending";
            this.unpaidCB.UseVisualStyleBackColor = true;
            this.unpaidCB.CheckedChanged += new System.EventHandler(this.unpaidCB_CheckedChanged);
            // 
            // remainsTB
            // 
            this.remainsTB.Location = new System.Drawing.Point(642, 75);
            this.remainsTB.Name = "remainsTB";
            this.remainsTB.ReadOnly = true;
            this.remainsTB.Size = new System.Drawing.Size(100, 22);
            this.remainsTB.TabIndex = 29;
            // 
            // remainsLB
            // 
            this.remainsLB.AutoSize = true;
            this.remainsLB.Location = new System.Drawing.Point(575, 79);
            this.remainsLB.Name = "remainsLB";
            this.remainsLB.Size = new System.Drawing.Size(61, 16);
            this.remainsLB.TabIndex = 30;
            this.remainsLB.Text = "Remains";
            // 
            // paymentUpdatePN
            // 
            this.paymentUpdatePN.Controls.Add(this.updatePaymentFromCustomerLB);
            this.paymentUpdatePN.Controls.Add(this.cfBtn);
            this.paymentUpdatePN.Controls.Add(this.paidTypeLB);
            this.paymentUpdatePN.Controls.Add(this.paymentTypeCB);
            this.paymentUpdatePN.Controls.Add(this.paidUpdateLB);
            this.paymentUpdatePN.Controls.Add(this.amountTB);
            this.paymentUpdatePN.Controls.Add(this.paymentHistoryLB);
            this.paymentUpdatePN.Controls.Add(this.paymentHistoryDGV);
            this.paymentUpdatePN.Controls.Add(this.cpnNameTB);
            this.paymentUpdatePN.Controls.Add(this.companyNameLB);
            this.paymentUpdatePN.Location = new System.Drawing.Point(107, 114);
            this.paymentUpdatePN.Name = "paymentUpdatePN";
            this.paymentUpdatePN.Size = new System.Drawing.Size(1008, 461);
            this.paymentUpdatePN.TabIndex = 31;
            // 
            // companyNameLB
            // 
            this.companyNameLB.AutoSize = true;
            this.companyNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLB.Location = new System.Drawing.Point(31, 129);
            this.companyNameLB.Name = "companyNameLB";
            this.companyNameLB.Size = new System.Drawing.Size(114, 16);
            this.companyNameLB.TabIndex = 0;
            this.companyNameLB.Text = "Company name";
            // 
            // cpnNameTB
            // 
            this.cpnNameTB.Location = new System.Drawing.Point(155, 129);
            this.cpnNameTB.Name = "cpnNameTB";
            this.cpnNameTB.ReadOnly = true;
            this.cpnNameTB.Size = new System.Drawing.Size(217, 22);
            this.cpnNameTB.TabIndex = 1;
            // 
            // paymentHistoryDGV
            // 
            this.paymentHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentHistoryDGV.Location = new System.Drawing.Point(528, 55);
            this.paymentHistoryDGV.Name = "paymentHistoryDGV";
            this.paymentHistoryDGV.RowHeadersWidth = 51;
            this.paymentHistoryDGV.RowTemplate.Height = 24;
            this.paymentHistoryDGV.Size = new System.Drawing.Size(453, 378);
            this.paymentHistoryDGV.TabIndex = 2;
            // 
            // paymentHistoryLB
            // 
            this.paymentHistoryLB.AutoSize = true;
            this.paymentHistoryLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentHistoryLB.Location = new System.Drawing.Point(532, 25);
            this.paymentHistoryLB.Name = "paymentHistoryLB";
            this.paymentHistoryLB.Size = new System.Drawing.Size(120, 16);
            this.paymentHistoryLB.TabIndex = 3;
            this.paymentHistoryLB.Text = "Payment History";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(155, 196);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(221, 22);
            this.amountTB.TabIndex = 4;
            // 
            // paidUpdateLB
            // 
            this.paidUpdateLB.AutoSize = true;
            this.paidUpdateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidUpdateLB.Location = new System.Drawing.Point(31, 202);
            this.paidUpdateLB.Name = "paidUpdateLB";
            this.paidUpdateLB.Size = new System.Drawing.Size(94, 16);
            this.paidUpdateLB.TabIndex = 5;
            this.paidUpdateLB.Text = "Paid Update";
            // 
            // paymentTypeCB
            // 
            this.paymentTypeCB.FormattingEnabled = true;
            this.paymentTypeCB.Items.AddRange(new object[] {
            "Cash",
            "Ebanking"});
            this.paymentTypeCB.Location = new System.Drawing.Point(155, 274);
            this.paymentTypeCB.Name = "paymentTypeCB";
            this.paymentTypeCB.Size = new System.Drawing.Size(217, 24);
            this.paymentTypeCB.TabIndex = 6;
            // 
            // paidTypeLB
            // 
            this.paidTypeLB.AutoSize = true;
            this.paidTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidTypeLB.Location = new System.Drawing.Point(31, 283);
            this.paidTypeLB.Name = "paidTypeLB";
            this.paidTypeLB.Size = new System.Drawing.Size(43, 16);
            this.paidTypeLB.TabIndex = 7;
            this.paidTypeLB.Text = "Type";
            // 
            // cfBtn
            // 
            this.cfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfBtn.Location = new System.Drawing.Point(34, 332);
            this.cfBtn.Name = "cfBtn";
            this.cfBtn.Size = new System.Drawing.Size(342, 53);
            this.cfBtn.TabIndex = 8;
            this.cfBtn.Text = "Confirm";
            this.cfBtn.UseVisualStyleBackColor = true;
            this.cfBtn.Click += new System.EventHandler(this.cfBtn_Click);
            // 
            // updatePaymentFromCustomerLB
            // 
            this.updatePaymentFromCustomerLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePaymentFromCustomerLB.AutoSize = true;
            this.updatePaymentFromCustomerLB.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePaymentFromCustomerLB.Location = new System.Drawing.Point(28, 25);
            this.updatePaymentFromCustomerLB.Name = "updatePaymentFromCustomerLB";
            this.updatePaymentFromCustomerLB.Size = new System.Drawing.Size(456, 33);
            this.updatePaymentFromCustomerLB.TabIndex = 32;
            this.updatePaymentFromCustomerLB.Text = "Update payments from customer";
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(982, 68);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(133, 29);
            this.approveBtn.TabIndex = 32;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // VacancyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 587);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.paymentUpdatePN);
            this.Controls.Add(this.remainsLB);
            this.Controls.Add(this.remainsTB);
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
            this.paymentUpdatePN.ResumeLayout(false);
            this.paymentUpdatePN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDGV)).EndInit();
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
        private System.Windows.Forms.TextBox remainsTB;
        private System.Windows.Forms.Label remainsLB;
        private System.Windows.Forms.Panel paymentUpdatePN;
        private System.Windows.Forms.Label paymentHistoryLB;
        private System.Windows.Forms.DataGridView paymentHistoryDGV;
        private System.Windows.Forms.TextBox cpnNameTB;
        private System.Windows.Forms.Label companyNameLB;
        private System.Windows.Forms.Label updatePaymentFromCustomerLB;
        private System.Windows.Forms.Button cfBtn;
        private System.Windows.Forms.Label paidTypeLB;
        private System.Windows.Forms.ComboBox paymentTypeCB;
        private System.Windows.Forms.Label paidUpdateLB;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Button approveBtn;
    }
}