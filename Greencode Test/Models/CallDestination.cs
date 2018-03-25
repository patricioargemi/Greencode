using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greencode_Test
{
    public class CallDestination
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public CallType Type { get; set; }

        public CallDestination(string name, double cost, CallType type)
        {
            Name = name;
            Cost = cost;
            Type = type;
        }
    }
}
