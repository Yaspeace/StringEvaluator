namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base
{
    public interface IEvaluatableToken
    {
        void Evaluate(Stack<double> stack);
    }
}
