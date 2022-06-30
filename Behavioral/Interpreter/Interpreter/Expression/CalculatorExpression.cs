namespace Interpreter
{
    interface CalculatorExpression
    {
        CalculatorExpression copy();
        CalculatorExpression replace(char name, CalculatorExpression exp);
        int evaluate(Context context);
    }
}
