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
            double result = divideTwoNumber(num1, num2);

            if (!double.IsNaN(result))
            {
                Console.WriteLine($"{num1} / {num2} = {divideTwoNumber(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Không thể chia được.");
            }


            Console.ReadKey();




        }
        static double addTwoNumber(double a, double b)
            {
                return a + b;
            }

        // Substract

        // Divide
        static double divideTwoNumber(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                return double.NaN;
        }

        // Multiple





    }
}
