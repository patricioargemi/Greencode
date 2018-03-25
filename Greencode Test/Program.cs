using Greencode_Test.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingController billingController = new BillingController();
            billingController.BillCurrentMonth();
        }
    }
}
