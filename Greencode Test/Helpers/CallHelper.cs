using Greencode_Test.CallFactory;
using Greencode_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test.Helpers
{
    class CallHelper
    {
        public double GetCallCost(CallType callType, int durationInMinutes, string destination = null)
        {
            var costMultiplier = 1;

            if (durationInMinutes > 0) costMultiplier = durationInMinutes;

            switch (callType)
            {
                case CallType.Local:
                    return MockData.LocalCallPricePerRegularMinute * costMultiplier;
                case CallType.LocalPrime:
                    return MockData.LocalCallPricePerPrimeMinute * costMultiplier;
                case CallType.National:
                    return MockData.CallDestinations.FirstOrDefault
                        (d => d.Type == CallType.National && d.Name == destination).Cost * costMultiplier;
                case CallType.International:
                    return MockData.CallDestinations.FirstOrDefault
                        (d => d.Type == CallType.International && d.Name == destination).Cost * costMultiplier;
                default:
                    return 0;
            }
        }

        public bool IsPrimeTime(DateTime time)
        {
            return (!(time.DayOfWeek == DayOfWeek.Saturday || time.DayOfWeek == DayOfWeek.Sunday) &&
                (MockData.PrimeTimeStart <= time.TimeOfDay && time.TimeOfDay <= MockData.PrimeTimeEnd));
        }

        public List<CallDetail> ProcessCalls(ref List<CallDetail> callsForProcessing)
        {
            var localCallsInstance = new LocalCall();
            var externalCallsInstance = new ExternalCall();

            var localCalls = callsForProcessing.Where(c => c.CallType == CallType.Local || c.CallType == CallType.LocalPrime);
            var externalCalls = callsForProcessing.Where(c => c.CallType == CallType.National || c.CallType == CallType.International);

            foreach (var call in localCalls)
            {
                call.Cost = localCallsInstance.MakeLocalCall(call.DurationInMinutes, call.TimeCalled);
            }

            foreach (var call in externalCalls)
            {
                call.Cost = externalCallsInstance.MakeExternalCall(call.DurationInMinutes, call.Destination);
            }

            return callsForProcessing;
        }
    }
}
