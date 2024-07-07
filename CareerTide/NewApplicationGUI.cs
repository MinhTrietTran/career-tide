using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CareerTide
{
    public partial class NewApplicationGUI : Form
    {
        public string POSITION { get; set; }
        public string COMPANY { get; set; }

        public int VACANCY_ID { get; set; }
        // cv
        private string selectedFilePathCV;
        private string selectedFileNameCV;
        // academic transcript
        private string selectedFilePathAT;
        private string selectedFileNameAT;
        public NewApplicationGUI()
        {
            InitializeComponent();
        }

        private void NewApplicationGUI_Load(object sender, EventArgs e)
        {
            positionTB.Text = POSITION;
            cpnTB.Text = COMPANY;
        }

        private void uploadCVBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image and PDF files (*.png;*.jpg;*.jpeg;*.pdf)|*.png;*.jpg;*.jpeg;*.pdf|All files (*.*)|*.*";
                openFileDialog.Title = "Select an image or PDF file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePathCV = openFileDialog.FileName;
                    selectedFileNameCV = Path.GetFileName(selectedFilePathCV);
                    cvPathTB.Text = selectedFilePathCV;
                    //MessageBox.Show("Selected file: " + selectedFilePathCV);
                }
            }
        }

        private void uploadATBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image and PDF files (*.png;*.jpg;*.jpeg;*.pdf)|*.png;*.jpg;*.jpeg;*.pdf|All files (*.*)|*.*";
                openFileDialog.Title = "Select an image or PDF file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePathAT = openFileDialog.FileName;
                    selectedFileNameAT = Path.GetFileName(selectedFilePathAT);
                    atPathTB.Text = selectedFilePathAT;
                    //MessageBox.Show("Selected file: " + selectedFilePathCV);
                }
            }
        }

        private void addCertificateBtn_Click(object sender, EventArgs e)
        {
            // Tạo một GroupBox mới để chứa certificatePB và Button cho chứng chỉ
            GroupBox groupBox = new GroupBox();
            groupBox.Width = 120; // Đặt chiều rộng cho GroupBox
            groupBox.Height = 120; // Đặt chiều cao cho GroupBox

            // Tạo một certificatePB mới để hiển thị hình ảnh chứng chỉ
            PictureBox certificatePB = new PictureBox();
            certificatePB.Width = 100;
            certificatePB.Height = 80;
            certificatePB.BorderStyle = BorderStyle.FixedSingle;
            certificatePB.SizeMode = PictureBoxSizeMode.StretchImage;
            certificatePB.Click += new EventHandler(certificatePB_Click); // Sự kiện click để thêm ảnh

            // Tạo một Button để xóa chứng chỉ
            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Width = 60;
            btnDelete.Click += new EventHandler(btnDelete_Click);

            // Thêm PictureBox và Button vào GroupBox
            groupBox.Controls.Add(certificatePB);
            groupBox.Controls.Add(btnDelete);

            // Đặt vị trí của PictureBox và Button trong GroupBox
            certificatePB.Location = new Point(10, 10);
            btnDelete.Location = new Point(50, 85);

            // Thêm GroupBox vào FlowLayoutPanel
            certificateFLP.Controls.Add(groupBox);
        }

        private void certificatePB_Click(object sender, EventArgs e)
        {
            PictureBox certificatePB = sender as PictureBox;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Nếu là hình ảnh
                if (openFileDialog.FileName.EndsWith(".jpg") || openFileDialog.FileName.EndsWith(".jpeg") || openFileDialog.FileName.EndsWith(".png"))
                {
                    certificatePB.Image = Image.FromFile(openFileDialog.FileName);
                }
                else if (openFileDialog.FileName.EndsWith(".pdf"))
                {
                    // Xử lý file PDF nếu cần
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btnDelete = sender as Button;
            GroupBox groupBox = btnDelete.Parent as GroupBox;
            certificateFLP.Controls.Remove(groupBox);
        }
    }
}
