using BUS;
using CareerTide.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerTide
{
    public partial class MainBoardGUI : Form
    {
        public MainBoardGUI()
        {
            InitializeComponent();
        }

        private void MainBoardGUI_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Email == null)
            {
                CurrentUser.Email = string.Empty;
            }
            if (CurrentUser.Role == null)
            {
                CurrentUser.Role = "";
            }
            powerPB.Hide();
            if (CurrentUser.Role != "")
            {
                powerPB.Show();
                if (CurrentUser.Role == "Employer" || CurrentUser.Role == "Admin")
                {
                
                    forEmployersLB.Hide();
                }
                SignInSignUpLB.Text = $"{CurrentUser.Role}";
                //SignInSignUpLB.ForeColor = System.Drawing.Color.White;
                //SignInSignUpLB.Enabled = false;
            }
           
        }

        private void SignInSignUpLB_Click(object sender, EventArgs e)
        {
            CurrentUser.Email = null;
            CurrentUser.Role = null;
            SignInGUI target = new SignInGUI();
            target.Show();
            this.Hide();
        }

        private void forEmployersLB_Click(object sender, EventArgs e)
        {
            Contact target = new Contact();
            target.Show();
            this.Hide();
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI_Load(sender, e);
        }

        private void employersPB_Click(object sender, EventArgs e)
        {
            EmployerGUI target = new EmployerGUI();
            target.Show();
            this.Hide();
        }

        private void jobsPB_Click(object sender, EventArgs e)
        {
            VacancyGUI target = new VacancyGUI();
            target.Show();
            this.Hide();
        }

        private void employeesPB_Click(object sender, EventArgs e)
        {
            ApplicationGUI target = new ApplicationGUI();
            target.Show();
            this.Hide();
        }
    }
}
