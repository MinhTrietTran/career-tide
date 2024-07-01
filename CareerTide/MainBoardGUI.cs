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
        public string ROLE { get; set; }
        public MainBoardGUI()
        {
            InitializeComponent();
        }

        private void MainBoardGUI_Load(object sender, EventArgs e)
        {
            if (ROLE != null)
            {
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
            MainBoardGUI_Load(sender, e);
        }
    }
}
