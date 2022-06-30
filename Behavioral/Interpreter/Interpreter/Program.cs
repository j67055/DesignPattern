using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Add('X', 4);
            context.Add('Y', 3);

            CalculatorExpression expression = new PlusExpression(new VariableExpression('X'), new VariableExpression('Y'));
            Console.WriteLine(expression.evaluate(context));

            context.Add('Z', 10);
            expression = expression.replace('X', new MinusExpression(new VariableExpression('Z'), new VariableExpression('X')));
            Console.WriteLine(expression.evaluate(context));
        }
    }
}
