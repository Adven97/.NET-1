using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Car : IAccelerate
    {
       
        private int acc = 50;
        private static int id = 1;
        private string nameOf; 

        public Car(string _name)
        {
            nameOf = _name + "#" + id;
            id++; 
        }

        public Car()
        {
        }

        public override string ToString()
        {
            return nameOf;
        }

        public int getSpeed()
        {
            return acc;

        }


        public int goFaster()
        {
            return acc+=5;

        }

        public int goSlower()
        {
            acc-=5;
            if (acc <= 0)
            {
                acc = 0;
            }
            return acc;
        }

    }
}
