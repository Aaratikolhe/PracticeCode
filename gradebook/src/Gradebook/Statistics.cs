using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public class Statistics
    {
        public double Average
        {
            get 
            { 
                return Sum / Count;
            }
        }

        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var a when a >= 90.0:
                        return  'A';

                    case var a when a >= 80.0:
                        return  'B';

                    case var a when a >= 70.0:
                        return 'C';

                    case var a when a >= 60.0:
                        return  'D';

                    default:
                        return 'F';

                }
            }
        }

           
        public double Sum;
        public double Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low=Math.Min(number,Low);
            High=Math.Max(number,High);
        }
        public Statistics()
        {
            Sum = 0.0;
            Count = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }


    }
}
