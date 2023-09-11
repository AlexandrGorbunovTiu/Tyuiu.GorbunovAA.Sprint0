using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorbunovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.GorbunovAA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(3, 3));
            Console.WriteLine(DataService.Substraction(9, 3));
            Console.WriteLine(DataService.Multiplication(2, 3));
            Console.WriteLine(DataService.Division(12, 2));
            Console.ReadKey();
        }
    }
}
