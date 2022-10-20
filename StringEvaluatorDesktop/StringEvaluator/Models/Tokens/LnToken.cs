namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class LnToken : IToken
    {
        public int Priority => 3;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(Math.Log(stack.Pop()));
        }
    }
}
