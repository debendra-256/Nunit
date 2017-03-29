using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
    class Program: ICalculator
    {
        static void Main(string[] args)
        {
        }

        public void sub(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
