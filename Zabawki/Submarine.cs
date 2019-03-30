using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Submarine : IDepth
    {

        private int depth = 150;

        private static int idS = 1;
        private string nameOf;

        public Submarine() { }

        public Submarine(string _name)
        {
            nameOf = _name + "#" + idS;
            idS++;
        }

        public override string ToString()
        {
            return nameOf;
        }

        public int getDepth()
        {
            return depth;
        }

        public int Deeper()
        {
            return depth += 10;
        }

        public int Higher()
        {
            depth -= 10;
            if (depth <= 0)
            {
                depth = 0;
            }

            return depth;
        }

    }
}
