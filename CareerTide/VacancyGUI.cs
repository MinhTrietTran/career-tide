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
using VacancyBUS = BUS.VacancyBUS;
using CurrentUser = BUS.CurrentUser;
using PaymentBUS = BUS.PaymentBUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CareerTide
{
    public partial class VacancyGUI : Form
    {
        VacancyBUS vacancyBUS = new VacancyBUS();
        PaymentBUS paymentBUS = new PaymentBUS();
        public VacancyGUI()
        {
            InitializeComponent();
        }

        private void VacancyGUI_Load(object sender, EventArgs e)
        {
            vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "All");
            newVacancyBtn.Hide();
            newVacancyBtn.Enabled = false;
            paymentUpdateBtn.Hide();
            noRoleLB.Hide();
            employerLB.Hide();
            adminLB.Hide();
            applicantLB.Hide();
            unpaidCB.Hide();
            remainsLB.Hide();
            remainsTB.Hide();
            paymentUpdatePN.Hide();
            approveBtn.Hide();
            applyNowBtn.Hide();
            if(CurrentUser.Role == "")
            {
                noRoleLB.Show();
            }
            if (CurrentUser.Role == "Employer") 
            {
                employerLB.Show();
                newVacancyBtn.Show();
                newVacancyBtn.Enabled = true;
            }
            if (CurrentUser.Role == "Applicant")
            {
                applyNowBtn.Show();
                applicantLB.Show();
            }
            if (CurrentUser.Role == "Admin")
            {
                //paymentUpdateBtn.Show();
                adminLB.Show();
                unpaidCB.Show();
                remainsLB.Show();
                remainsTB.Show();
            }
        }

        private void newVacancyBtn_Click(object sender, EventArgs e)
        {
            NewVacancyGUI target = new NewVacancyGUI();
            target.Show();
            this.Hide();
        }

        private void LogoPB_Click(object sender, EventArgs e)
        {
            MainBoardGUI target = new MainBoardGUI();
            target.Show();
            this.Hide();
        }

        private void employersPB_Click(object sender, EventArgs e)
        {
            EmployerGUI target = new EmployerGUI();
            target.Show();
            this.Hide();
        }

        private void unpaidCB_CheckedChanged(object sender, EventArgs e)
        {
            if (unpaidCB.Checked == true)
            {
                vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "Pending");
            }
            else
            {
                vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "All");
            }
        }

        private void vacancyDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(CurrentUser.Role == "Admin")
            {
                DataGridViewRow selectedRow = vacancyDGV.SelectedRows[0];

                int vacancyID = Convert.ToInt32(selectedRow.Cells[0].Value);
                //string position = selectedRow.Cells[1].Value.ToString();
                //string number = selectedRow.Cells[2].Value.ToString();
                //string openDate = selectedRow.Cells[3].Value.ToString();
                //string closeDate = selectedRow.Cells[4].Value.ToString();
                //string description = selectedRow.Cells[5].Value.ToString();
                //string postType = selectedRow.Cells[6].Value.ToString();
                //string cost = selectedRow.Cells[7].Value.ToString();
                string status = selectedRow.Cells[8].Value.ToString();
                //string employerID = selectedRow.Cells[9].Value.ToString();
                string remains = paymentBUS.GetRemainingCost(vacancyID).ToString();
                remainsTB.Text = remains;
                if(Convert.ToInt32(remains) > 0)
                {
                    paymentUpdateBtn.Show();
                }
                else
                {
                    if (status == "Pending")
                    {
                        approveBtn.Show();
                    }
                    else
                    {
                        approveBtn.Hide();
                    }
                    paymentUpdateBtn.Hide();
                }
            }
        }

        private void paymentUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                paymentUpdatePN.Show();
                DataGridViewRow selectedRow = vacancyDGV.SelectedRows[0];

                int vacancyID = Convert.ToInt32(selectedRow.Cells[0].Value);
                //string position = selectedRow.Cells[1].Value.ToString();
                //string number = selectedRow.Cells[2].Value.ToString();
                //string openDate = selectedRow.Cells[3].Value.ToString();
                //string closeDate = selectedRow.Cells[4].Value.ToString();
                //string description = selectedRow.Cells[5].Value.ToString();
                //string postType = selectedRow.Cells[6].Value.ToString();
                //string cost = selectedRow.Cells[7].Value.ToString();
                //string status = selectedRow.Cells[8].Value.ToString();
                int employerID = Convert.ToInt32(selectedRow.Cells[9].Value);
                paymentUpdatePN.Show();
                cpnNameTB.Text = paymentBUS.GetCompanyName(employerID);
                paymentHistoryDGV.DataSource = paymentBUS.getAllPaymentDataByVacancyID(vacancyID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when update payment: {ex.Message}");
            }
        }

        private void cfBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = vacancyDGV.SelectedRows[0];

            int vacancyID = Convert.ToInt32(selectedRow.Cells[0].Value);
            //string position = selectedRow.Cells[1].Value.ToString();
            //string number = selectedRow.Cells[2].Value.ToString();
            //string openDate = selectedRow.Cells[3].Value.ToString();
            //string closeDate = selectedRow.Cells[4].Value.ToString();
            //string description = selectedRow.Cells[5].Value.ToString();
            //string postType = selectedRow.Cells[6].Value.ToString();
            //string cost = selectedRow.Cells[7].Value.ToString();
            //string status = selectedRow.Cells[8].Value.ToString();
            float amount = Convert.ToSingle(amountTB.Text);
            string paymentType = paymentTypeCB.Text;
            int employerID = Convert.ToInt32(selectedRow.Cells[9].Value);
            if (amountTB.Text == "" || paymentTypeCB.Text == "")
            {
                MessageBox.Show("Please fill all the information!");
            }
            else
            {
                try
                {
                    if(paymentBUS.insertNewPaymentData(amount, paymentType, vacancyID))
                    {
                        MessageBox.Show("Updated successfully!");
                        paymentUpdatePN.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Update fail! Please check the information again!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when update payment: {ex.Message}");
                }
            }
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = vacancyDGV.SelectedRows[0];

            int vacancyID = Convert.ToInt32(selectedRow.Cells[0].Value);
            //string position = selectedRow.Cells[1].Value.ToString();
            //string number = selectedRow.Cells[2].Value.ToString();
            //string openDate = selectedRow.Cells[3].Value.ToString();
            //string closeDate = selectedRow.Cells[4].Value.ToString();
            //string description = selectedRow.Cells[5].Value.ToString();
            //string postType = selectedRow.Cells[6].Value.ToString();
            //string cost = selectedRow.Cells[7].Value.ToString();
            //string status = selectedRow.Cells[8].Value.ToString();
            int employerID = Convert.ToInt32(selectedRow.Cells[9].Value);

            vacancyBUS.ApproveVacancy(vacancyID);
            vacancyDGV.DataSource = vacancyBUS.viewVacancyDataByStatus(CurrentUser.Email, CurrentUser.Role, "All");

            // Tạo file PDF từ DataTable
            byte[] pdfData = PdfGenerator.GeneratePdf(paymentBUS.getAllPaymentDataByVacancyID(vacancyID));

            // Gửi email với file PDF đính kèm
            EmailSender.SendEmailWithAttachment(vacancyBUS.GetRepresentative(employerID), "Invoice", "You have completed a vacancy payment.", pdfData, "Invoice.pdf");

        }

        private void applyNowBtn_Click(object sender, EventArgs e)
        {
            NewApplicationGUI target = new NewApplicationGUI();
            target.Show();
            this.Hide();
        }
    }
}
