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

namespace CareerTide
{
    public partial class VacancyGUI : Form
    {
        public VacancyGUI()
        {
            InitializeComponent();
        }

        private void VacancyGUI_Load(object sender, EventArgs e)
        {
            newVacancyBtn.Hide();
            newVacancyBtn.Enabled = false;
            if (CurrentUser.Role == "Employer") 
            {
                newVacancyBtn.Show();
                newVacancyBtn.Enabled = true;
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
    }
}
