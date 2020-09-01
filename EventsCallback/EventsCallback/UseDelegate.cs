using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCallback
{
    // 79 Actions
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

            Action<int, int> calcAction = (int x, int y) => Console.WriteLine(x + y);


            Console.WriteLine(calc(5, 5));

            Calculate calc1 = (int x, int y) => x + y;
            Console.WriteLine(calc1(10, 10));


            calcAction(7, 8);

        }

    }
}
