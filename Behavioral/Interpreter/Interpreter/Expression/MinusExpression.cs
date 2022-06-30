namespace Interpreter
{
    class MinusExpression : CalculatorExpression
    {
        private CalculatorExpression left, right;

        public MinusExpression(CalculatorExpression left, CalculatorExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public CalculatorExpression copy()
            => new MinusExpression(left, right);

        public CalculatorExpression replace(char name, CalculatorExpression exp)
            => new MinusExpression(left.replace(name, exp), right.replace(name, exp));

        public int evaluate(Context context)
            => left.evaluate(context) - right.evaluate(context);
    }
}
