using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Interfaces
{
    public interface IPaymentStrategy
    {
        void PayCharges( double amount);
    }

    class CashPayment : IPaymentStrategy
    {
        public void PayCharges(double amount)
        {
            Console.WriteLine("Paid amount:{0} By Cash", amount);
        }
    }

    class CardPayment : IPaymentStrategy
    {
        public void PayCharges(double amount)
        {
            Console.WriteLine("Paid amount:{0} By Card", amount);
        }
    }
}
