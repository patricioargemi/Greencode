using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test.CallFactory
{
    public class ExternalCall : ICall
    {        
        public override double MakeExternalCall(int durationInMinutes, CallDestination destination)
        {
            var helper = new Helpers.CallHelper();

            return helper.GetCallCost(destination.Type, durationInMinutes, destination.Name);
        }

        public override double MakeLocalCall(int durationInMinutes, DateTime dateCalled)
        {
            throw new NotImplementedException();
        }
    }
}
