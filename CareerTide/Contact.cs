using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBUS = BUS.ContactBUS;

namespace CareerTide
{
    public partial class Contact : Form
    {
        ContactBUS contactBUS = new ContactBUS();
        public Contact()
        {
            InitializeComponent();
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target =   new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void signInLB_Click(object sender, EventArgs e)
        {
            SignInGUI target = new SignInGUI();
            target.Show();
            this.Hide();
        }

        private void SignInSignUpLB_Click(object sender, EventArgs e)
        {
            SignInGUI target = new SignInGUI();
            target.Show();
            this.Hide();
        }

        private void contactMeBtn_Click(object sender, EventArgs e)
        {
            if (contactBUS.IsCompanyExist(cpnNameTB.Text.ToString()))
            {
                MessageBox.Show("The company has been registered!");
            }
            else if (contactBUS.IsEmailExist(workEmailTB.Text.ToString()))
            {
                MessageBox.Show("The email has been used!");
            }
            else
            {
                string rpsttName = rpsttNameTB.Text.ToString();
                string workTittle = workTittleTB.Text.ToString();
                string workEmail = workEmailTB.Text.ToString();
                string phoneNumber = phoneNumberTB.Text.ToString();
                string cpnName = cpnNameTB.Text.ToString();
                string cpnLocation = cpnLocationTB.Text.ToString();
                string cpnTaxCode = cpnTaxCodeTB.Text.ToString();
                while(rpsttName == "" ||
                    workTittle == "" ||
                    workEmail == "" ||
                    phoneNumber == "" ||
                    cpnName == "" ||
                    cpnLocation == "" ||
                    cpnTaxCode == "")
                {
                    MessageBox.Show("Please fill in all the required information!");
                    return;
                }
               
                // Gui mail lai cho nha tuyen dung biet mat khau
                // Code
                try
                {
                    contactBUS.SendMailToEmployer(workEmail, phoneNumber);
                    // Goi ham tao tai khoan moi cho nha tuyen dung
                    // Code
                    contactBUS.InsertNewEmployer(rpsttName, workTittle, workEmail, phoneNumber, cpnName, cpnLocation, cpnTaxCode);

                    MessageBox.Show("Contact successfully! Check your email!");
                    // Qua trang chu
                    MainBoardGUI target = new MainBoardGUI();
                    target.Show();
                    this.Hide();

                }
                catch
                {
                       MessageBox.Show("Failed to send email!");
                }
                
            }
        }
    }
}
