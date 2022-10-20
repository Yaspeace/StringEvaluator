namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class MultiplyToken : IToken
    {
        public int Priority => 2;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(stack.Pop() * stack.Pop());
        }
    }
}
