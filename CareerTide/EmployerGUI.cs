using System;
using System.Data;
using System.Windows.Forms;
using EmployerBUS = BUS.EmployerBUS;
using CurrentUser = BUS.CurrentUser;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

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
            newContractPN.Hide();
            newContractBtn.Hide();
            statisticsBtn.Hide();
            companyListDGV.DataSource = employerBUS.GetCompanyData(CurrentUser.Role);
            powerPB.Hide();
            if (CurrentUser.Role != "")
            {
                powerPB.Show();
                if (CurrentUser.Role == "Employer")
                {
                    companyListDGV.Columns["EmployerID"].Visible = false;
                    forEmployersLB.Hide();
                }
                if (CurrentUser.Role == "Admin")
                {
                    newContractBtn.Show();
                    forEmployersLB.Hide();
                    statisticsBtn.Show();
                }
                else
                {
                    companyListDGV.Columns["EmployerID"].Visible = false;
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

        private void mainPN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newContractBtn_Click(object sender, EventArgs e)
        {
            if (companyListDGV.SelectedRows.Count > 0)
            {
                newContractBtn.Hide();
                newContractPN.Show();
                DataGridViewRow selectedRow = companyListDGV.SelectedRows[0];
                //int employerID = Convert.ToInt32(selectedRow.Cells["EmployerID"].Value);
                string companyName = selectedRow.Cells["Name"].Value.ToString();
                cpnNameTB.Text = companyName;

            }
            else
            {
                MessageBox.Show("Please select a company to create a new contract.");
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (startDateDTP.Value < DateTime.Today)
            {
                MessageBox.Show("Unvalid start day!");
                return;
            }
            if (startDateDTP.Value > endDateDTP.Value)
            {
                MessageBox.Show("Start day must be before End day!");
                return;
            }
            string startDate = startDateDTP.Value.ToString("yyyy-MM-dd");
            string endDate = endDateDTP.Value.ToString("yyyy-MM-dd");
            string contractInfo = contractInfoRTB.Text.ToString();
            DataGridViewRow selectedRow = companyListDGV.SelectedRows[0];
            int employerID = Convert.ToInt32(selectedRow.Cells["EmployerID"].Value);
 
            if (contractInfo == "")
            {
                MessageBox.Show("Please fill in all the fields!");
                return;
            }
            else
            {         
                employerBUS.InsertNewContract(startDate, endDate,contractInfo, employerID);
                MessageBox.Show("Add contract successfully!");
                newContractPN.Hide();
                // Reload the company list
                EmployerGUI_Load(sender, e);
            }
        }


        private void statisticsBtn_Click(object sender, EventArgs e)
        {

            DataTable dt = employerBUS.GetCompanyData(CurrentUser.Role); // Giả sử bạn đã có hàm lấy dữ liệu từ cơ sở dữ liệu
            DataTable filteredDt = employerBUS.GetCompaniesAboutToExpire(dt);

            if (filteredDt.Rows.Count > 0)
            {
                GeneratePDF(filteredDt);
            }
            else
            {
                MessageBox.Show("No company's contract is about to expire.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void GeneratePDF(DataTable dt)
        {
            string path = "contract-report.pdf";
            using (PdfWriter writer = new PdfWriter(path))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Thêm tiêu đề
                    Paragraph header = new Paragraph("===Companies whose contracts are about to expire===");
                    header.SetTextAlignment(TextAlignment.CENTER);
                    document.Add(header);

                    // Tạo bảng và thêm dữ liệu từ DataTable
                    Table table = new Table(4);
                    table.AddHeaderCell("Company name");
                    table.AddHeaderCell("Adress");
                    table.AddHeaderCell("Tax code");
                    table.AddHeaderCell("Email");

                    foreach (DataRow row in dt.Rows)
                    {
                        table.AddCell(row["Name"].ToString());
                        table.AddCell(row["Location"].ToString());
                        table.AddCell(row["TaxCode"].ToString());
                        table.AddCell(employerBUS.GetEmployerEmail(int.Parse(row["EmployerID"].ToString())));
                    }

                    document.Add(table);
                }
            }

            MessageBox.Show("The PDF file has been successfully created at: " + path, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void employeesPB_Click(object sender, EventArgs e)
        {
            ApplicationGUI applicationGUI = new ApplicationGUI();
            applicationGUI.Show();
            this.Hide();
        }

        private void jobsPB_Click(object sender, EventArgs e)
        {
            VacancyGUI vacancy = new VacancyGUI();
            vacancy.Show();
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
            AboutUsGUI aboutUsGUI = new AboutUsGUI();
            aboutUsGUI.Show();
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
