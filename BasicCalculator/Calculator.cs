using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Calculator
    {
        public double firstNumber, secondNumber;
        public string operatorType;
        public double result;

        // Create a constructor with no parameters or arguments
        public Calculator()
        {
            firstNumber = 0;
            secondNumber = 0;
            operatorType = "";
            result = 0;
        }

        // Create a method to perform the calculation named calculate that returns decimal
        public double calculate(double firstNumber, double secondNumber, string operatorType)
        {
            switch (operatorType)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "×":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    break;
            }
            // Return the result of the calculation as a decimal with two decimal places
            return Math.Round(result, 2);
        }
    }
}
