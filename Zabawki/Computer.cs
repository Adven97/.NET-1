using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public class Computer
    {
        private static int idC = 1;     
        private string nameOf;

        public Computer()
        {
        }

        public Computer(string _name)
        {
            nameOf = _name + "#" + idC;
            idC++;

        }

        public override string ToString()
        {
            return nameOf;
        }

    }
}
