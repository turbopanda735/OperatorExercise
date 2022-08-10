using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("welcome to the operator exercise");
            Console.WriteLine("please enter the first number");
            var num1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("please enter the second number");
            var num2 = double.Parse((Console.ReadLine()));

            var additionSum = num1 + num2;
            var subtactionSum = num1 - num2;
            var multiplicationSum = num1 * num2;
            var quotient = num1 / num2;
            var remainder = num1 % num2;

            Console.WriteLine($"Addition: {additionSum}. Subtraction: {subtactionSum}. Multiplication: {multiplicationSum}. Division: {quotient}.");
            Console.WriteLine($"{num1} / {num2} is {quotient} remainder {remainder}.");
            Console.WriteLine($"Please note: {num1} and {num2} are set to doubles to display more accurate division. As a result, {remainder} is the remainder of division for whole numbers. It will not divide whole numbers into decimals.");
            
            
            Console.WriteLine("please enter radius of the circle");
            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.ReadLine();
        }
        static double AreaOfCircle(double r)
        {
            var area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"The area of a circle with a radius of {r} is {area}.");
            return area;
        }
    }
}

