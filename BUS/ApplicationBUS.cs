using DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ApplicationBUS
    {
        ApplicationDAO applicationDAO = new ApplicationDAO();

        public void insertNewApplication(String coverLetter, String cvFilePath, String academicTranscriptFilePath, String applicationStatus, String applicant, int vacancy)
        {
            byte[] cvData = File.ReadAllBytes(cvFilePath);
            byte[] academicTranscriptData = File.ReadAllBytes(academicTranscriptFilePath);

            applicationDAO.insertNewApplication(coverLetter, cvData, academicTranscriptData, applicationStatus, applicant, vacancy);

        }

        public void updateApplication(int applicationID, String coverLetter, String cvFilePath, String academicTranscriptFilePath, String applicationStatus)
        {
            byte[] cvData = File.ReadAllBytes(cvFilePath);
            byte[] academicTranscriptData = File.ReadAllBytes(academicTranscriptFilePath);

            applicationDAO.updateApplication(applicationID, coverLetter, cvData, academicTranscriptData, applicationStatus);
        }

    }
}
