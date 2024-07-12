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
using SignUpBUS = BUS.SignUpBUS;

namespace CareerTide
{
    public partial class SignUpGUI : Form
    {
        SignUpBUS signUpBUS = new SignUpBUS();
        public SignUpGUI()
        {
            InitializeComponent();
        }

        private void SignUpGUI_Load(object sender, EventArgs e)
        {

        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void signInLB_Click(object sender, EventArgs e)
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

        private void signUnBtn_Click(object sender, EventArgs e)
        {
            if(signUpBUS.IsEmailExist(emailTB.Text.ToString()))
            {
                MessageBox.Show("The email has been used!");
            }
            else
            {
                string name = nameTB.Text.ToString();
                string email = emailTB.Text.ToString();
                string password = passwordTB.Text.ToString();
                while (name == "" || email == "" || password == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                    return;
                }
                try
                {
                    // Goi ham tao tai khoan moi cho nha ung vien
                    // Code
                    signUpBUS.InsertNewApplicant(name, email, password);

                    MessageBox.Show("Contact successfully! Sign In now !");
                    // Qua trang chu
                    SignInGUI target = new SignInGUI();
                    target.Show();
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("Failed to create account!");
                }
            }
        }

        private void employeesPB_Click(object sender, EventArgs e)
        {
            ApplicationGUI applicationGUI = new ApplicationGUI();
            applicationGUI.Show();
            this.Hide();
        }

        private void jobsPB_Click(object sender, EventArgs e)
        {
            VacancyGUI vacancyGUI = new VacancyGUI();
            vacancyGUI.Show();
            this.Hide();
        }

        private void employersPB_Click(object sender, EventArgs e)
        {
            EmployerGUI employerGUI = new EmployerGUI();
            employerGUI.Show();
            this.Hide();
        }

        private void aboutPB_Click(object sender, EventArgs e)
        {
            AboutUsGUI aboutGUI = new AboutUsGUI();
            aboutGUI.Show();
            this.Hide();
        }

        private void logOutPB_Click(object sender, EventArgs e)
        {
            SignInGUI signInGUI = new SignInGUI();
            signInGUI.Show();
            this.Hide();
        }
    }
}
