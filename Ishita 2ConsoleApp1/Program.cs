using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_2ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(1, 2));
            Console.WriteLine(SumTriple(3, 2));
            Console.WriteLine(SumTriple(2, 2));
            Console.ReadLine();
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
            
            
        }

    }
}
