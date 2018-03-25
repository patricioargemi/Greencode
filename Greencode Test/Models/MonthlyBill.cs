using Greencode_Test.CallFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test.Models
{
    public class MonthlyBill
    {
        public List<CallDetail> ProcessedCalls { get; set; }
        public MonthlyPayment MonthlyPayment { get; set; }

        public MonthlyBill(List<CallDetail> processedCalls, MonthlyPayment monthlyPayment)
        {
            ProcessedCalls = processedCalls;
            MonthlyPayment = monthlyPayment;
        }        
    }
}
