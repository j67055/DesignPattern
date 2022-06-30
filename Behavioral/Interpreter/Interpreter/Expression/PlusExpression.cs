namespace Interpreter
{
    class PlusExpression : CalculatorExpression
    {
        private CalculatorExpression left, right;

        public PlusExpression(CalculatorExpression left, CalculatorExpression right)
        {
            this.left = left;
            this.right = right;
        } 

        public CalculatorExpression copy()
            => new PlusExpression(left, right);

        public CalculatorExpression replace(char name, CalculatorExpression exp)
            => new PlusExpression(left.replace(name, exp), right.replace(name, exp));

        public int evaluate(Context context)
            => left.evaluate(context) + right.evaluate(context);
    }
}
