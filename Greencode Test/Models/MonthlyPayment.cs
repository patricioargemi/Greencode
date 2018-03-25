using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test
{
    public class MonthlyPayment
    {        
        public double Amount { get; set; }

        public MonthlyPayment(double monthlyPaymentAmount)
        {
            Amount = monthlyPaymentAmount;
        }
    }
}
