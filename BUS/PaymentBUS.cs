using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PaymentBUS
    {
        PaymentDAO paymentDAO = new PaymentDAO();   

        public bool insertNewPaymentData(float amount, string paymentType, int vacancyID)
        {
            return paymentDAO.insertNewPaymentData(amount, paymentType, vacancyID);
        }

        public DataTable getAllPaymentDataByVacancyID(int vacancyID)
        {
            return paymentDAO.getAllPaymentDataByVacancyID(vacancyID);
        }
    }
}
