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
                target.ROLE = role;
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
    }
}
