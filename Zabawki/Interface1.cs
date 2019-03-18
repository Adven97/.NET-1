using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface ISpeed
    {
        int increaseSpeed();
        int decreaseSpeed();

        int getSpeed();
    }

    interface Wings
    {
        int increase();
        int decrease();

        int getWingspan();
    }

    interface Depth
    {
        int increaseDepth();
        int decreaseDepth();

        int getDepth();
    }

}
