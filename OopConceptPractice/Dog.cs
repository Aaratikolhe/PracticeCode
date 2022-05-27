using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConceptPractice
{
    class Dog:Animal
    {
        private string breed;

        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The dog is barking");
        }
        public void WagTail()
        {
            Console.WriteLine("The dog wags tail");
        }

    }
}
