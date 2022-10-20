namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class TanToken : IToken
    {
        public int Priority => 3;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(Math.Tan(stack.Pop()));
        }
    }
}
