using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationBUS applicationBUS = new ApplicationBUS();
            //applicationBUS.updateApplication(2, "tien recommend", "D:\\Downloaded File\\dog.jpg", "D:\\Downloaded File\\dog.jpg", ApplicationStatusEnum.Pending);
           // applicationBUS.insertNewApplication("tien recommend", "D:\\Downloaded File\\dog.jpg", "D:\\Downloaded File\\dog.jpg", "Checked", "tien123", 4);
           CertificateBUS certificateBUS = new CertificateBUS();
            certificateBUS.updateCertificate(1, "D:\\Downloaded File\\dog.jpg");
            //certificateBUS.insertNewCertificate(2, "D:\\Downloaded File\\dog.jpg");
            //Application.Run(new Form1());
        }
    }
}
