namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class NumberToken : IToken
    {
        private double value;

        public int Priority => 0;

        public NumberToken(double value)
        {
            this.value = value;
        }

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(value);
        }
    }
}
