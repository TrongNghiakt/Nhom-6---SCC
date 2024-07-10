using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_6___SCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hello
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {addTwoNumber(num1,num2)}");


            


        }
        static double addTwoNumber(double a, double b)
            {
                return a + b;
            }

        // Substract

        // Divide

        // Multiple





    }
}
