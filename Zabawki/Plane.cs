using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Plane :  IHeight, IAccelerate
    {

        private int acc = 400;
        private int height = 1000;
        private static int idP = 1;
        private string nameOf;

        public Plane()
        {
        }

        public Plane(string _name)
        {
            nameOf = _name + "#" + idP;
            idP++;
        }

        public override string ToString()
        {
            return nameOf;
        }


        public int goHigher()
        {
           return height+=100;
        }

        public int goLower()
        {
            height-=100;
            if (height <= 0)
            {
                height = 0;
            }
            return height;
        }

        public int getHeight()
        {
            return height;
        }

        public int goFaster()
        {
            return acc += 50;

        }

        public int goSlower()
        {
            acc -= 50;
            if (acc <= 0)
            {
                acc = 0;
            }
            return acc;
        }

        public int getSpeed()
        {
            return acc;

        }
    }
}
