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

            Console.WriteLine($"{num1} + {num2} = {addTwoNumber(num1, num2)}");

            Console.WriteLine($"{num1} - {num2} = {subTwoNumber(num1, num2)}");

            Console.WriteLine($"{num1} * {num2} = {mulTwoNumber(num1, num2)}");

            // Input for complex numbers
            Console.Write("Enter the first real complex number: ");
            double real1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the first imaginary complex number: ");
            double imag1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second real complex number: ");
            double real2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second imaginary complex number: ");
            double imag2 = Convert.ToDouble(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(real1, imag1);
            ComplexNumber complex2 = new ComplexNumber(real2, imag2);

            ComplexNumber complexSum = complex1 + complex2;

            Console.WriteLine($"({complex1}) + ({complex2}) = {complexSum}");

            Console.ReadKey();
        }

        static double addTwoNumber(double a, double b)
        {
            return a + b;
        }

        static double subTwoNumber(double a, double b)
        {
            return a - b;
        }

        // Multiply
        static double mulTwoNumber(double a, double b)
        {
            return a * b;
        }
    }

    struct ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Phương thức tính tổng hai số phức
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
