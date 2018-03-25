using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test.CallFactory
{
    public class LocalCall : ICall
    {        
        public override double MakeExternalCall(int durationInMinutes, CallDestination destination)
        {
            throw new NotImplementedException();
        }

        public override double MakeLocalCall(int durationInMinutes, DateTime dateCalled)
        {
            var helper = new Helpers.CallHelper();

            if (durationInMinutes > 0)
            {
                if (helper.IsPrimeTime(dateCalled))
                {
                    return helper.GetCallCost(CallType.LocalPrime, durationInMinutes);
                }

                return helper.GetCallCost(CallType.Local, durationInMinutes);
            }

            return helper.GetCallCost(CallType.Local, durationInMinutes);
        }        
    }
}
