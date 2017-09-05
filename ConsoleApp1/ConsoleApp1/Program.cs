using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("epsilon vvedite ");
            double epsilon = 0;

            while (!Double.TryParse(Console.ReadLine(), out epsilon))
                Console.WriteLine("nevernii vvod");

            double ans = 1/2;
            int i = 2;
            double slag = ans;

            while (slag < epsilon)
            {
                slag = i * (i + 1);
                slag = 1 / slag;
                ans += slag;
                i++;
            }

            Console.WriteLine("otvet " + ans);
            Console.ReadKey();
        }
    }
}
