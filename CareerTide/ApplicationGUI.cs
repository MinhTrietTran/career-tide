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

namespace CareerTide
{
    public partial class ApplicationGUI : Form
    {
        ApplicationBUS applicationBUS = new ApplicationBUS();
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
            ExitBtn.Hide();
            applicationDetailPN.Hide();
            noRoleNotiLB.Hide();
            if (CurrentUser.Role == "Applicant")
            {
                applicationDGV.DataSource = applicationBUS.LoadApplicationForApplicant(CurrentUser.Email);
                applicationDGV.Columns["ApplicationID"].Visible = false;
                applicationDGV.Columns["CoverLetter"].Visible = false;
                applicationDGV.Columns["CV"].Visible = false;
                applicationDGV.Columns["AcademicTranscript"].Visible = false;
            }
            else if(CurrentUser.Role == "Employer")
            {
                applicationDGV.DataSource = applicationBUS.LoadApplicationForEmployer(CurrentUser.Email);
                applicationDGV.Columns["ApplicationID"].Visible = false;
                applicationDGV.Columns["CoverLetter"].Visible = false;
                applicationDGV.Columns["CV"].Visible = false;
                applicationDGV.Columns["AcademicTranscript"].Visible = false;
            }
            else if(CurrentUser.Role == "Admin")
            {
                applicationDGV.DataSource = applicationBUS.LoadApplicationForAdmin();
                applicationDGV.Columns["CoverLetter"].Visible = false;
                applicationDGV.Columns["CV"].Visible = false;
                applicationDGV.Columns["AcademicTranscript"].Visible = false;
            }
            else 
            {
                   noRoleNotiLB.Show();
            }
            
        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            ExitBtn.Show();
            DataGridViewRow selectedRow = applicationDGV.SelectedRows[0];
            applicationDetailPN.Show();
            int applicationID = Convert.ToInt32(selectedRow.Cells["ApplicationID"].Value);
            string candidateName = selectedRow.Cells["Candidate_Name"].Value.ToString();
            string position = selectedRow.Cells["Position"].Value.ToString();
            string company = selectedRow.Cells["Company_Name"].Value.ToString();
            string status = selectedRow.Cells[4].Value.ToString();
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
            yourApplicationLB.Text = "Application Detail";
        }

        private void employeesPB_Click(object sender, EventArgs e)
        {
            ApplicationGUI_Load(sender, e);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ApplicationGUI_Load(sender, e);
        }
    }
}
