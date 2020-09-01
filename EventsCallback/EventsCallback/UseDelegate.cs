using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCallback
{
    // 78_delegates_lambda
    public class UseDelegate
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }

        public UseDelegate()
        {
            Calculate calc = (int x, int y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y; // multiple lines must Use "return"

                }
            ;
            Console.WriteLine(calc(5, 5));

            Calculate calc1 = (int x, int y) => x + y;
            Console.WriteLine(calc1(5, 5));



        }

    }
}
