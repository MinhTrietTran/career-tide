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
using NewVacancyBUS = BUS.NewVacancyBUS;
using CurrentUser = BUS.CurrentUser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CareerTide
{
    public partial class NewVacancyGUI : Form
    {
        NewVacancyBUS newVacancyBUS = new NewVacancyBUS();
        public NewVacancyGUI()
        {
            InitializeComponent();
        }

        private void newVacancyBtn_Click(object sender, EventArgs e)
        {
            if (openDateDTP.Value < DateTime.Today)
            {
                MessageBox.Show("Unvalid open day!");
                return;
            }
            if (openDateDTP.Value > closeDateDTP.Value)
            {
                MessageBox.Show("Open day must be before close day!");
                return;
            }
            string position = positionTB.Text.ToString();
            string number = numberTB.Text.ToString();
            string postType = postTypeCB.Text.ToString();
            string description = descriptionRTB.Text.ToString();
            string openDate = openDateDTP.Value.ToString("yyyy-MM-dd");
            string closeDate = closeDateDTP.Value.ToString("yyyy-MM-dd");
            int employerID = newVacancyBUS.GetEmployerID(CurrentUser.Email);
            if (position == "" ||
                number == "" ||
                postType == "" ||
                description == ""
                )
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }
            else
            {
                if (newVacancyBUS.IsContractValid(employerID) != 1)
                {
                    MessageBox.Show("You have not signed the contract yet!");
                    return;
                }
                else
                {
                    newVacancyBUS.AddNewVacancy(position, int.Parse(number), openDate, closeDate, description, postType, employerID);
                    MessageBox.Show("Request successfully! Please payroll at the earliest time possible.");
                    VacancyGUI target = new VacancyGUI();
                    target.Show();
                    this.Hide();
                }

            }
        }

        // Chỉ cho phép nhập số vào TextBox numberTB
        private void numberTB_TextChanged(object sender, EventArgs e)
        {
            string text = numberTB.Text;
            if (text.Any(c => !char.IsDigit(c)))
            {
                // Xóa các ký tự không phải số
                numberTB.Text = string.Concat(text.Where(c => char.IsDigit(c)));
                numberTB.SelectionStart = numberTB.Text.Length; // Di chuyển con trỏ về cuối TextBox
            }
        }

        private void NewVacancyGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
