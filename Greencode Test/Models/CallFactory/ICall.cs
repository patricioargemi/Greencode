using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test
{
    public abstract class ICall
    {
        public abstract double MakeLocalCall(int durationInMinutes, DateTime dateCalled);

        public abstract double MakeExternalCall(int durationInMinutes, CallDestination destination);                 
    }
}
