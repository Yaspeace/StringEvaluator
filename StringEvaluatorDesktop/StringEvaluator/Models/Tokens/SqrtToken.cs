namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class SqrtToken : IToken
    {
        public int Priority => 3;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(Math.Sqrt(stack.Pop()));
        }
    }
}
