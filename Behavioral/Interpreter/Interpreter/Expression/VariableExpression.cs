namespace Interpreter
{
    class VariableExpression : CalculatorExpression
    {
        private char name;
        public VariableExpression(char name)
            => this.name = name;

        public CalculatorExpression copy()
            => new VariableExpression(name);

        public CalculatorExpression replace(char name, CalculatorExpression exp)
        {
            if (this.name == name)
                return exp.copy();

            return new VariableExpression(this.name);
        }

        public int evaluate(Context context)
            => context[name];
    }
}
