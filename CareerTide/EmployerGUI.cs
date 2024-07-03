using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployerBUS = BUS.EmployerBUS;
using CurrentUser = BUS.CurrentUser;

namespace CareerTide
{
    public partial class EmployerGUI : Form
    {
        EmployerBUS employerBUS = new EmployerBUS();
        public EmployerGUI()
        {
            InitializeComponent();
        }

        private void EmployerGUI_Load(object sender, EventArgs e)
        {
            companyListDGV.DataSource = employerBUS.GetCompanyData(CurrentUser.Role);
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
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }
    }
}
