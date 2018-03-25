using Greencode_Test.Helpers;
using Greencode_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test.Controllers
{
    public class BillingController
    {        
        public void BillCurrentMonth()
        {
            var monthlyPlan = MockData.MonthlyPayment;
            var monthlyPlanRemainingAmount = 0.0;
            var callsForProcessing = MockData.CallsMade;
            double totalPrice = 0.0;
            double localCallsTotalPrice = 0.0;
            double externalCallsTotalPrice = 0.0;

            CallHelper helperInstance = new CallHelper();
            helperInstance.ProcessCalls(ref callsForProcessing);

            MonthlyBill bill = new MonthlyBill(callsForProcessing, monthlyPlan);

            var processedCalls = callsForProcessing.OrderBy(c => c.TimeCalled).ToList();
            
            //Debug order
            //var processedCalls = callsForProcessing;

            totalPrice = processedCalls.Sum(s => s.Cost);
            localCallsTotalPrice = processedCalls.Where(c => c.CallType == CallType.Local || c.CallType == CallType.LocalPrime).Sum(c => c.Cost);
            externalCallsTotalPrice = processedCalls.Where(c => c.CallType == CallType.National || c.CallType == CallType.International).Sum(c => c.Cost);
            monthlyPlanRemainingAmount = monthlyPlan.Amount - totalPrice;

            Console.WriteLine("Abono mensual: $" + monthlyPlan.Amount);
            Console.WriteLine("Detalle de consumos del mes (por fecha):");
            Console.WriteLine("Tipo de llamada | Destino | Costo por Minuto | Horario de llamado | Duración (en minutos) | Costo total por llamada");
            //Print recipe
            foreach (var call in processedCalls)
            {        
                Console.Write(call.CallType.ToString() + " | ");                
                Console.Write(call.Destination.Name + " | ");
                Console.Write("$" + call.Destination.Cost.ToString() + " | ");
                Console.Write(call.TimeCalled.DayOfWeek + ", " + call.TimeCalled.ToString() + " | ");
                Console.Write(call.DurationInMinutes.ToString() + " | ");
                Console.Write("$" + call.Cost.ToString());

                Console.WriteLine();                
            }

            Console.WriteLine("Consumo en llamadas Locales: $" + localCallsTotalPrice);

            Console.WriteLine("Consumo en llamadas Nacionales/Internacionales: $" + externalCallsTotalPrice);

            Console.WriteLine("Costo total en consumo mensual: $" + totalPrice);            

            Console.WriteLine("Crédito restante en el plan mensual: $" + monthlyPlanRemainingAmount);            

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }    
}
