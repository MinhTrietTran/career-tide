using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationBUS = BUS.ApplicationBUS;
using CurrentUser = BUS.CurrentUser;
using CertificateBUS = BUS.CertificateBUS;
using EmailSender = BUS.EmailSender;
using PdfiumViewer;
using System.IO;

namespace CareerTide
{
    public partial class ApplicationGUI : Form
    {
        PdfiumViewer.PdfViewer pdf;
        ApplicationBUS applicationBUS = new ApplicationBUS();
        CertificateBUS certificateBUS = new CertificateBUS();
        public ApplicationGUI()
        {
            InitializeComponent();
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void jobsPB_Click(object sender, EventArgs e)
        {
            VacancyGUI target = new VacancyGUI();
            target.Show();
            this.Hide();
        }

        private void employersPB_Click(object sender, EventArgs e)
        {
            EmployerGUI target = new EmployerGUI();
            target.Show();
            this.Hide();
        }

        private void ApplicationGUI_Load(object sender, EventArgs e)
        {
            employerApproveBtn.Hide();
            adminApproveBtn.Hide();
            adminRejectBtn.Hide();
            ExitBtn.Hide();
            applicationDetailPN.Hide();
            noRoleNotiLB.Hide();
            cvPN.Hide();
            if (CurrentUser.Role == "Applicant")
            {
                applicationDGV.DataSource = applicationBUS.LoadApplicationForApplicant(CurrentUser.Email);
                applicationDGV.Columns["ApplicationID"].Visible = false;
                applicationDGV.Columns["CoverLetter"].Visible = false;
            }
            else if (CurrentUser.Role == "Employer")
            {
                employerApproveBtn.Show();
                adminRejectBtn.Show();
                applicationDGV.DataSource = applicationBUS.LoadApplicationForEmployer(CurrentUser.Email);
                applicationDGV.Columns["ApplicationID"].Visible = false;
                applicationDGV.Columns["CoverLetter"].Visible = false;
            }
            else if (CurrentUser.Role == "Admin")
            {
                adminApproveBtn.Show();
                adminRejectBtn.Show();
                applicationDGV.DataSource = applicationBUS.LoadApplicationForAdmin();
                applicationDGV.Columns["CoverLetter"].Visible = false;
            }
            else
            {
                detailBtn.Hide();
                noRoleNotiLB.Show();
            }

        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            exitCVBtn.Hide();
            ExitBtn.Show();
            if (applicationDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = applicationDGV.SelectedRows[0];
                applicationDetailPN.Show();
                int applicationID = Convert.ToInt32(selectedRow.Cells["ApplicationID"].Value);
                string candidateName = selectedRow.Cells["Candidate_Name"].Value.ToString();
                string position = selectedRow.Cells["Position"].Value.ToString();
                string company = selectedRow.Cells["Company_Name"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                string coverLetter = selectedRow.Cells["CoverLetter"].Value.ToString();
                //byte[] cv = (byte[])selectedRow.Cells["CV"].Value;
                //byte[] at = (byte[])selectedRow.Cells["AcademicTranscript"].Value;

                applicantTB.Text = candidateName;
                positionTB.Text = position;
                companyTB.Text = company;
                statusTB.Text = status;
                coverLetterRTB.Text = coverLetter;
                //applicationBUS.SetPictureBoxImage(cvPB, cv);
                //applicationBUS.SetPictureBoxImage(atPB, at);

                // Load thu bang diem gpa
                byte[] at = applicationBUS.GetAcademicTranscript(applicationID);
                applicationBUS.SetPictureBoxImage(atPB, at);

                // Load cers
                LoadCertificates(applicationID);

                yourApplicationLB.Text = "Application Detail";
            }
            else
            {
                MessageBox.Show("Please select an application to view details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void employeesPB_Click(object sender, EventArgs e)
        {
            ApplicationGUI_Load(sender, e);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            yourApplicationLB.Text = "Manage Applications";
            //ApplicationGUI_Load(sender, e);
            applicationDetailPN.Hide();
            ExitBtn.Hide();
        }

        private void viewCVBtn_Click(object sender, EventArgs e)
        {
            cvPN.Show();
            DataGridViewRow selectedRow = applicationDGV.SelectedRows[0];
            int applicationID = Convert.ToInt32(selectedRow.Cells["ApplicationID"].Value);
            // Load cv pdf
            pdf = new PdfViewer();
            cvPN.Controls.Add(pdf);
            byte[] cv = applicationBUS.GetCV(applicationID);
            var stream = new MemoryStream(cv);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
            exitCVBtn.Show();
        }

        // Cac ham duoi day phuc vu load cac certificates len ui
        private void LoadCertificates(int applicationID)
        {
            // Làm sạch FlowLayoutPanel trước khi thêm các chứng chỉ mới
            certificateFLP.Controls.Clear();
            List<byte[]> certificates = certificateBUS.GetCertificatesByApplicationID(applicationID);
            int i = 0;
            foreach (byte[] certificate in certificates)
            {
                PictureBox certificatePB = new PictureBox();
                certificatePB.Size = new Size(220, 342);
                certificatePB.SizeMode = PictureBoxSizeMode.StretchImage;
                certificatePB.Image = Image.FromStream(new MemoryStream(certificate));
                certificatePB.Name = "certificatePB" + i;
                certificateFLP.Controls.Add(certificatePB);
                i++;
            }
        }

        private void exitCVBtn_Click(object sender, EventArgs e)
        {
            cvPN.Hide();
            pdf.Dispose();
            exitCVBtn.Hide();
            viewCVBtn.Show();
        }

        private void adminApproveBtn_Click(object sender, EventArgs e)
        {
            if (applicationDGV.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn trong DataGridView
                DataGridViewRow selectedRow = applicationDGV.SelectedRows[0];
                int applicationID = Convert.ToInt32(selectedRow.Cells["ApplicationID"].Value);

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show("Are you sure to approve this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Xử lý dựa trên kết quả của hộp thoại
                if (dialogResult == DialogResult.Yes)
                {
                    // Thực hiện phê duyệt đơn xin việc (hoặc các hành động tương tự)
                    applicationBUS.ProcessApplication(applicationID);

                    // Load lại dữ liệu hoặc cập nhật giao diện
                    ApplicationGUI_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please select an application to approve.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void adminRejectBtn_Click(object sender, EventArgs e)
        {
            if (applicationDGV.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn trong DataGridView
                DataGridViewRow selectedRow = applicationDGV.SelectedRows[0];
                int applicationID = Convert.ToInt32(selectedRow.Cells["ApplicationID"].Value);

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show("Are you sure to reject this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Xử lý dựa trên kết quả của hộp thoại
                if (dialogResult == DialogResult.Yes)
                {
                    // Thực hiện từ chối đơn xin việc (hoặc các hành động tương tự)
                    applicationBUS.RejectApplication(applicationID);

                    // Load lại dữ liệu hoặc cập nhật giao diện
                    ApplicationGUI_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Please select an application to reject.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void employerApproveBtn_Click(object sender, EventArgs e)
        {
            if (applicationDGV.SelectedRows.Count > 0)
            {
                // Lấy dòng đã chọn trong DataGridView
                DataGridViewRow selectedRow = applicationDGV.SelectedRows[0];
                int applicationID = Convert.ToInt32(selectedRow.Cells["ApplicationID"].Value);
                string applicantEmail = selectedRow.Cells["Email"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show("Are you sure to approve this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Xử lý dựa trên kết quả của hộp thoại
                if (dialogResult == DialogResult.Yes)
                {
                    // Thực hiện phê duyệt đơn xin việc (hoặc các hành động tương tự)
                    applicationBUS.ApproveApplication(applicationID);
                    // Gửi email 
                    EmailSender.SendEmail(applicantEmail, "YOUR APPLICATION HAS BEEN APPROVED!", "An application has been approved recently. Please check the career tide app for more information.");

                    // Load lại dữ liệu hoặc cập nhật giao diện
                    ApplicationGUI_Load(sender, e);

                }
            }
            else
            {
                MessageBox.Show("Please select an application to approve.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
