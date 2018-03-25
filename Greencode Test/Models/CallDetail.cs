using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test.Models
{
    public class CallDetail
    {
        public CallType CallType { get; set; }
        public CallDestination Destination { get; set; }
        public DateTime TimeCalled { get; set; }
        public int DurationInMinutes { get; set; }
        public double Cost { get; set; }

        public CallDetail(CallType callType, DateTime timeCalled, int durationInMinutes, CallDestination destination, double cost = 0)
        {
            CallType = callType;
            Destination = destination;        
            TimeCalled = timeCalled;
            DurationInMinutes = durationInMinutes;
            Cost = cost;
        }
    }
}
