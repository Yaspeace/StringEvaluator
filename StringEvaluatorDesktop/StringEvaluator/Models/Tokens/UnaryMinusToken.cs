namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class UnaryMinusToken : IToken
    {
        public int Priority => 3;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(-stack.Pop());
        }
    }
}
