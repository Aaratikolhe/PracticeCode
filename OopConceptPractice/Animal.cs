using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConceptPractice
{
    class Animal
    {
        private string type;
        private Double weight;
        private string color;
        //public int MyProperty { get; set; }    
        //public string Type1 { get => type; set => type = value; }

        public string Type
        {
            get 
            { 
                return Type;
            }
            set
            { 
                Type = value;
            }
        }

        public double Weight 
        { 
            get => weight; 
            set => weight = value; 
        }
        public string Color 
        { get => color;
          set => color = value; 
        }
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise");
        }

        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }
    }
}
