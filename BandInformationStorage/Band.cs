using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandInformationStorage
{
   class Band
    {

        public string Name;
        int Musician;
        public void Announce()
        {
            Console.WriteLine("Welcome " + Name + " to the stage");
        }
    }
}
