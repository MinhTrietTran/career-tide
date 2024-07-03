using DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CertificateBUS
    {
        CertificateDAO certificateDAO = new CertificateDAO();

        public void insertNewCertificate(int applicationID, String certificateFilePath)
        {
            byte[] certificateData = File.ReadAllBytes(certificateFilePath);

            certificateDAO.insertNewCertificate(applicationID, certificateData);   
        }
        public void updateCertificate(int certificateID, String certificateFilePath)
        {
            byte[] certificateData = File.ReadAllBytes(certificateFilePath);
            
            certificateDAO.updateCertificate(certificateID, certificateData);
        }
    }
}
