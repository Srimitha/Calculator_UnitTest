using System;

namespace Calculator.Core
{
    public class CalculatorMethods
    {
        public int Add(int number1,int number2)
        {
            int result = number1 + number2;
            return result;
        }
        public int Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }
        public int Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
        public int Divide(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }
    }
}
