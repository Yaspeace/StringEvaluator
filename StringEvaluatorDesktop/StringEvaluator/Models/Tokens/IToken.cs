namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public interface IToken
    {
        int Priority { get; }
        void PerformOperation(Stack<double> stack);
    }
}
