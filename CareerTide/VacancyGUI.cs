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
using VacancyBUS = BUS.VacancyBUS;
using CurrentUser = BUS.CurrentUser;

namespace CareerTide
{
    public partial class VacancyGUI : Form
    {
        VacancyBUS vacancyBUS = new VacancyBUS();
        public VacancyGUI()
        {
            InitializeComponent();
        }

        private void VacancyGUI_Load(object sender, EventArgs e)
        {
            vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "All");
            newVacancyBtn.Hide();
            newVacancyBtn.Enabled = false;
            paymentUpdateBtn.Hide();
            noRoleLB.Hide();
            employerLB.Hide();
            adminLB.Hide();
            applicantLB.Hide();
            unpaidCB.Hide();
            if(CurrentUser.Role == "")
            {
                noRoleLB.Show();
            }
            if (CurrentUser.Role == "Employer") 
            {
                employerLB.Show();
                newVacancyBtn.Show();
                newVacancyBtn.Enabled = true;
            }
            if (CurrentUser.Role == "Applicant")
            {
                applicantLB.Show();
            }
            if (CurrentUser.Role == "Admin")
            {
                paymentUpdateBtn.Show();
                adminLB.Show();
                unpaidCB.Show();
            }
        }

        private void newVacancyBtn_Click(object sender, EventArgs e)
        {
            NewVacancyGUI target = new NewVacancyGUI();
            target.Show();
            this.Hide();
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void employersPB_Click(object sender, EventArgs e)
        {
            EmployerGUI target = new EmployerGUI();
            target.Show();
            this.Hide();
        }

        private void unpaidCB_CheckedChanged(object sender, EventArgs e)
        {
            if (unpaidCB.Checked == true)
            {
                vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "Pending");
            }
            else
            {
                vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "All");
            }
        }
    }
}
