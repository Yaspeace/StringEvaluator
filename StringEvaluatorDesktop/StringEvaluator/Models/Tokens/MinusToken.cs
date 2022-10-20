namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class MinusToken : IToken
    {
        public int Priority => 1;

        public void PerformOperation(Stack<double> stack)
        {
            var rOperand = stack.Pop();
            var lOperand = stack.Pop();
            stack.Push(lOperand - rOperand);
        }
    }
}
