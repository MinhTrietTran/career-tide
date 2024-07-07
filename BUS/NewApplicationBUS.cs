using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewApplicationDAO = DAO.NewApplicationDAO;
using System.IO;

namespace BUS
{
    public class NewApplicationBUS
    {
        NewApplicationDAO newApplicationDAO = new NewApplicationDAO();
        public void InsertNewApplication(string coverLetter, string cVPath, string academicTranscriptPath, string applicant, int vacancy)
        {
            // Convert path to binary data
            byte[] cVData = File.ReadAllBytes(cVPath);
            byte[] academicTranscriptData = File.ReadAllBytes(academicTranscriptPath);

            newApplicationDAO.InsertNewApplication(coverLetter, cVData, academicTranscriptData, applicant, vacancy);
        }
    }
}
