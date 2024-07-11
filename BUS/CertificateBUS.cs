using DAO;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class CertificateBUS
    {
        CertificateDAO certificateDAO = new CertificateDAO();

        public void insertNewCertificate(int applicationID, byte[] certificateFile)
        {
            //byte[] certificateData = File.ReadAllBytes(certificateFilePath);

            certificateDAO.insertNewCertificate(applicationID, certificateFile);   
        }

        public void updateCertificate(int certificateID, String certificateFilePath)
        {
            byte[] certificateData = File.ReadAllBytes(certificateFilePath);
            
            certificateDAO.updateCertificate(certificateID, certificateData);
        }

        public int GetLastestApplicationID()
        {
            return certificateDAO.GetLastestApplicationID();
        }

        public byte[] GetImageData(PictureBox pictureBox)
        {
            try
            {
                if (pictureBox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox.Image.Save(ms, ImageFormat.Jpeg); // Lưu ảnh dưới dạng JPEG (hoặc bạn có thể chọn định dạng khác)
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image: " + ex.Message);
            }
            return null;
        }
    }
}
