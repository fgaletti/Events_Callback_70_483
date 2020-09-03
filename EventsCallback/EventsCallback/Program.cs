using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCallback
{
    class Program
    {
        // 80 events
        static void Main(string[] args)
        {
            Car c = new Car();
            c.OnChange += C_OnChange;
            c.Speed = 65;
        }

        private static void C_OnChange()
        {
            Console.WriteLine(" Event fired : car is > 60");
        }
    }
}
