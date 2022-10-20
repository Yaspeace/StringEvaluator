namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class CosToken : IToken
    {
        public int Priority => 3;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(Math.Cos(stack.Pop()));
        }
    }
}
