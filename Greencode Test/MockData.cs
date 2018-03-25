using Greencode_Test.CallFactory;
using Greencode_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test
{
    public static class MockData
    {
        //Estos valores representan datos que podrían estar persistidos 
        //en una base de datos o ser la respuesta de algún servicio/API.

        public static double LocalCallPricePerRegularMinute = 0.1;
        public static double LocalCallPricePerPrimeMinute = 0.2;

        public static TimeSpan PrimeTimeStart = new TimeSpan(8, 0, 0);
        public static TimeSpan PrimeTimeEnd = new TimeSpan(20, 0, 0);

        public static MonthlyPayment MonthlyPayment = new MonthlyPayment(100.0);

        public static List<CallDestination> CallDestinations = new List<CallDestination>()
        {
            { new CallDestination("City_1", 0.30, CallType.National)},
            { new CallDestination("City_2", 0.32, CallType.National)},
            { new CallDestination("City_3", 0.35, CallType.National)},
            { new CallDestination("City_4", 0.38, CallType.National)},
            { new CallDestination("City_5", 0.40, CallType.National)},

            { new CallDestination("Country_1", 0.50, CallType.International)},
            { new CallDestination("Country_2", 0.52, CallType.International)},
            { new CallDestination("Country_3", 0.55, CallType.International)},
            { new CallDestination("Country_4", 0.58, CallType.International)},
            { new CallDestination("Country_5", 0.60, CallType.International)},

            { new CallDestination("Local_1", LocalCallPricePerRegularMinute, CallType.Local)},
            { new CallDestination("Local_2", LocalCallPricePerPrimeMinute, CallType.LocalPrime)},            
        };

        public static List<CallDetail> CallsMade = new List<CallDetail>()
        {
            { new CallDetail(CallType.National, new DateTime(2018, 03, 01, 01, 00, 00), 3, CallDestinations[0]) },
            { new CallDetail(CallType.National, new DateTime(2018, 03, 02, 13, 00, 00), 6, CallDestinations[1]) },
            { new CallDetail(CallType.National, new DateTime(2018, 03, 03, 16, 00, 00), 7, CallDestinations[2]) },
            { new CallDetail(CallType.National, new DateTime(2018, 03, 05, 03, 00, 00), 14, CallDestinations[3]) },
            { new CallDetail(CallType.National, new DateTime(2018, 03, 15, 22, 00, 00), 2, CallDestinations[4]) },

            { new CallDetail(CallType.International, new DateTime(2018, 03, 04, 05, 00, 00), 4, CallDestinations[5]) },
            { new CallDetail(CallType.International, new DateTime(2018, 03, 11, 15, 00, 00), 6, CallDestinations[6]) },
            { new CallDetail(CallType.International, new DateTime(2018, 03, 13, 12, 00, 00), 8, CallDestinations[7]) },
            { new CallDetail(CallType.International, new DateTime(2018, 03, 17, 13, 00, 00), 12, CallDestinations[8]) },
            { new CallDetail(CallType.International, new DateTime(2018, 03, 22, 09, 00, 00), 7, CallDestinations[9]) },

            { new CallDetail(CallType.Local, new DateTime(2018, 03, 03, 11, 00, 00), 12, CallDestinations[10]) },
            { new CallDetail(CallType.Local, new DateTime(2018, 03, 06, 07, 00, 00), 4, CallDestinations[10]) },
            { new CallDetail(CallType.LocalPrime, new DateTime(2018, 03, 08, 14, 00, 00), 8, CallDestinations[11]) },
            { new CallDetail(CallType.LocalPrime, new DateTime(2018, 03, 12, 08, 00, 00), 5, CallDestinations[11]) },
            { new CallDetail(CallType.Local, new DateTime(2018, 03, 24, 22, 40, 00), 21, CallDestinations[10]) }
        };
    }
}
