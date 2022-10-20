namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class DivideToken : IToken
    {
        public int Priority => 2;

        public void PerformOperation(Stack<double> stack)
        {
            var rOperand = stack.Pop();
            var lOperand = stack.Pop();
            stack.Push(lOperand / rOperand);
        }
    }
}
