using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForgotPasswordBUS = BUS.ForgotPasswordBUS;

namespace CareerTide
{
    public partial class ForgotPasswordGUI : Form
    {
        ForgotPasswordBUS forgotPasswordBUS = new ForgotPasswordBUS();
        public ForgotPasswordGUI()
        {
            InitializeComponent();
        }

        private void signUnBtn_Click(object sender, EventArgs e)
        {
            if(!forgotPasswordBUS.IsEmailExist(emailTB.Text.ToString()))
            {
                MessageBox.Show("Email does not existed!");
            }
            else
            {
                MessageBox.Show("Please check your email.");
                forgotPasswordBUS.SendPassword(emailTB.Text.ToString());
            }
        }

        private void forEmployersLB_Click(object sender, EventArgs e)
        {
            Contact target = new Contact();
            target.Show();
            this.Hide();
        }

        private void SignInSignUpLB_Click(object sender, EventArgs e)
        {
            SignInGUI target = new SignInGUI();
            target.Show();
            this.Hide();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            SignInGUI target = new SignInGUI();
            target.Show();
            this.Hide();
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void ForgotPasswordGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
