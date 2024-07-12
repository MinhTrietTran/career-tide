using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ApplicationDAO = DAO.ApplicationDAO;

namespace BUS
{
    public class ApplicationBUS
    {
        ApplicationDAO applicationDAO = new ApplicationDAO();


        public void updateApplication(int applicationID, String coverLetter, String cvFilePath, String academicTranscriptFilePath, String applicationStatus)
        {
            byte[] cvData = File.ReadAllBytes(cvFilePath);
            byte[] academicTranscriptData = File.ReadAllBytes(academicTranscriptFilePath);

            applicationDAO.updateApplication(applicationID, coverLetter, cvData, academicTranscriptData, applicationStatus);
        }

        public DataTable LoadApplicationForApplicant(string applicantEmail)
        {
            return applicationDAO.LoadApplicationForApplicant(applicantEmail);
        }

        public DataTable LoadApplicationForEmployer(string employerEmail)
        {
            return applicationDAO.LoadApplicationForEmployer(employerEmail);
        }

        public DataTable LoadApplicationForAdmin() { return applicationDAO.LoadApplicationForAdmin(); }

        public void SetPictureBoxImage(PictureBox pictureBox, byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    ms.Position = 0; // Ensure the stream's position is at the beginning
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox.Image = null; // Hoặc bạn có thể đặt hình ảnh mặc định nếu không có dữ liệu
            }
        }

        public byte[] GetAcademicTranscript(int applicationID) => applicationDAO.GetAcademicTranscript(applicationID);
        public byte[] GetCV(int applicationID) => applicationDAO.GetCV(applicationID);
    }
}
