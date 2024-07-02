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

namespace CareerTide
{
    public partial class EmployerGUI : Form
    {
        public string ROLE { get; set; }
        EmployerBUS employerBUS = new EmployerBUS();
        public EmployerGUI()
        {
            InitializeComponent();
        }

        private void EmployerGUI_Load(object sender, EventArgs e)
        {
            companyListDGV.DataSource = employerBUS.GetCompanyData(ROLE);
            powerPB.Hide();
            if (ROLE != "")
            {
                powerPB.Show();
                if (ROLE == "Employer" || ROLE == "Admin")
                {

                    forEmployersLB.Hide();
                }
                SignInSignUpLB.Text = $"{ROLE}";
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
            target.ROLE = this.ROLE;
            target.Show();
            this.Hide();
        }
    }
}
