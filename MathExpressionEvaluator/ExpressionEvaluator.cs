using System;
using System.Collections.Generic;
using System.Text;

namespace MathExpressionEvaluator
{
    public class ExpressionEvaluator
    {
        private string expression;

        public ExpressionEvaluator(string Expression)
        {
            expression = Expression;
        }

        /**
         * Evaluate Expression by splitting when '+' operator is found and add the array of tokens to get sum
         * **/
        public int Evaluate()
        {
            int sum = 0;
            string[] tokens = expression.Split('+');
            foreach (var item in tokens)
            {
                sum = sum + int.Parse(item);
            }
            return sum;
        }

    }
}
