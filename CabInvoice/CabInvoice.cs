using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoice
{
    class Cab
    {
        public double cost { get; set; }
        public double kilometer { get; set; }
        public double minute { get; set; }
    }

    class CabAverage
    {
        public double count { get; set; }
        public double total { get; set; }
        public double average { get; set; }
    }
}