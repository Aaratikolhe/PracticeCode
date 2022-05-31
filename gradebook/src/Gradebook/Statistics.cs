using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public class Statistics
    {
        public double average;
        public double high;
        public double low;
        public char letter;
        public Statistics()
        {
            average = 0.0;
            high = double.MinValue;
            low = double.MaxValue;
        }
    }
}
