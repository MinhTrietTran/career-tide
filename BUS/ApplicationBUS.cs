using DAO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable viewAllApplicationDataByStatusForAdmin(string userRole, string applicationStatus) 
            => applicationDAO.viewAllApplicationDataByStatusForAdmin(userRole, applicationStatus);

        public DataTable viewAllApplicationDataByStatusForEmployer(int vacancyID, string userRole, string applicationStatus)
            => applicationDAO.viewAllApplicationDataByStatusForEmployer(vacancyID, userRole, applicationStatus);

        public DataTable viewAllApplicationDataByStatusForApplicant(string applicantEmail, string userRole, string applicationStatus)
            => applicationDAO.viewAllApplicationDataByStatusForApplicant(applicantEmail, userRole, applicationStatus);

    }
}
