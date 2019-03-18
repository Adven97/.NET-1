using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : ISpeed
    {
        private string nameof;
        static int id = 1;

        private int speed;
        Car(string _name)
        {
            nameof = _name+"#"+id;
        }

        public override string ToString()
        {
            return nameof;
        }



        public int increaseSpeed()
        {
            throw new NotImplementedException();
        }

        public int decreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public int getSpeed()
        {
            throw new NotImplementedException();

            return speed;
            
        }
    }
}
