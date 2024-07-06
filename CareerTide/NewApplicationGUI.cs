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
    public partial class NewApplicationGUI : Form
    {
        public string POSITION { get; set; }
        public string COMPANY { get; set; }
        public NewApplicationGUI()
        {
            InitializeComponent();
        }

        private void NewApplicationGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
