using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Development
{
    internal class Calculations
    {
        public void Values()
        {
            string[] operationValues = {"+", "-", "/", "*"};

            Console.WriteLine("Please enter a number: ");

            var firstNumber = Int64.Parse(Console.ReadLine());

            Console.WriteLine("Enter an arithmetic operator: ");

            var operation = Console.ReadLine();

            Console.WriteLine("Please enter the second number: ");

            var secondNumber = Int64.Parse(Console.ReadLine());

            Calculator(firstNumber, secondNumber, operation, operationValues);

        }
        private void Calculator(long firstNumber, long secondNumber, string operation, string[] operationValues)
        {
            if (operation == "+") { Console.WriteLine("\n" + "Your answer is: " + (firstNumber + secondNumber) + "\n"); }

            else if (operation == "-") { Console.WriteLine("\n" + "Your answer is: " + (firstNumber - secondNumber) + "\n"); }

            else if (operation == "*") { Console.WriteLine("\n" + "Your answer is: " + (firstNumber * secondNumber) + "\n"); }

            else if (operation == "/") { Console.WriteLine("\n" + "Your answer is: " + (firstNumber / secondNumber) + "\n"); }

            Console.WriteLine("\n" + "Would you like to do another calculation? [y/n]" + "\n");

            var keepItGoing = Console.ReadLine();

            if (keepItGoing.ToLower() == "y") { Console.Clear(); Values(); }

            if(keepItGoing.ToLower() == "n") { Environment.Exit(0); }

            if ((operationValues.Any(operation.Contains) == false)){ 
                
                Console.WriteLine("Please enter an appropriate operator (+, -, *, /) and try again!");

                Console.ReadLine();

                Console.Clear();

                Values();
            }

            Console.ReadLine();
        }
    }
            
}
