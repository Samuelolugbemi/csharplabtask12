using System;

namespace MulticastDelegateApp
{
    public delegate void Calculator(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = Addition;
            calc += Multiplication;
            Console.Write("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            calc(firstNum, secondNum);
        }
        static void Addition(int a, int b)
        {
            Console.WriteLine($"Sum is: {a + b}");
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine($"Product is: {a * b}");
        }
    }
}
