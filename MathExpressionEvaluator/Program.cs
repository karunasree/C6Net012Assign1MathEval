using System;

namespace MathExpressionEvaluator
{
    class Program
    {

        /**
         * Taking Input from Console.
         * Instantiate ExpressionEvaluator and Call Evaluate Method
        **/
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter numbers to add with + symbol");
                    Console.WriteLine("Result= {0}", new ExpressionEvaluator(Console.ReadLine()).Evaluate());
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Expression, try again", ex.Message);
                }
            }
        }

    }
}

