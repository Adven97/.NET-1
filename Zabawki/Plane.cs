using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Plane :  IHeight
    {
      
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
    }
}
