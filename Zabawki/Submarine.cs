using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Submarine : IDepth, IAccelerate
    {

        private int depth = 150;
        private int acc = 100;
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

        public int getDepth()
        {
            return depth;
        }

        public int goFaster()
        {
            return acc += 10;

        }

        public int goSlower()
        {
            acc -= 10;
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
