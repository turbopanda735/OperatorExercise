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
            var divisionSum = num1 / num2;
            var quotient = num1 % num2;

            Console.WriteLine($"Addition: {additionSum}. Subtraction: {subtactionSum}. Multiplication: {multiplicationSum}. Division: {divisionSum}.");
            Console.WriteLine($"{num1}/{num2} is {divisionSum} remainder {quotient}.");
            Console.WriteLine($"Please note: {num1} and {num2} are set to doubles to display more accurate division. As a result, {quotient} is the remainder of division for whole numbers. It will not divide whole numbers into decimals.");

            Console.WriteLine("please enter radius of the circle");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}

