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
using SignInBUS = BUS.SignInBUS;

namespace CareerTide
{
    public partial class SignInGUI : Form
    {
        SignInBUS signInBUS = new SignInBUS();

        private string username;
        private string password;
        public SignInGUI()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            username = userNameTB.Text.ToString();
            password = passwordTB.Text.ToString();
            string role = signInBUS.Authentication(username, password);
            if(role != null)
            {
                MessageBox.Show("Login successfully!");
                MainBoardGUI target = new MainBoardGUI();
                // Lay gia tri cho bien tinh de dung xuyen suot chuong trinh
                CurrentUser.Role = role;
                CurrentUser.Email = username;
                target.Show();
                this.Hide();
            }
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void forEmployersLB_Click(object sender, EventArgs e)
        {
            Contact target = new Contact();
            target.Show();
            this.Hide();
        }

        private void signUpLB_Click(object sender, EventArgs e)
        {
            SignUpGUI target = new SignUpGUI();
            target.Show();
            this.Hide();
        }

        private void showPasswordPB_Click(object sender, EventArgs e)
        {
            if(passwordTB.PasswordChar == '\0')
            {
                hidePasswordPB.BringToFront();
                passwordTB.PasswordChar = '*';
            }
        }

        private void hidePasswordPB_Click(object sender, EventArgs e)
        {
            if (passwordTB.PasswordChar == '*')
            {
                showPasswordPB.BringToFront();
                passwordTB.PasswordChar = '\0';
            }
        }

        private void forgotPasswordLB_Click(object sender, EventArgs e)
        {
            ForgotPasswordGUI target = new ForgotPasswordGUI();
            target.Show();
            this.Hide();
        }

        private void SignInGUI_Load(object sender, EventArgs e)
        {

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
            SignInGUI aboutGUI = new SignInGUI();
            aboutGUI.Show();
            this.Hide();
        }
    }
}
