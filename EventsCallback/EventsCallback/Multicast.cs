using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCallback
{
    // 76_Multicast
    class Multicast
    {
        public delegate void Del();

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public void Multicast2()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }

    }
}
