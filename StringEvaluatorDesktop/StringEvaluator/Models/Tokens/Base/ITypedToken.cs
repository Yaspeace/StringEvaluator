namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base
{
    public interface ITypedToken
    {
        public TokenTypes Type { get; }

        void Sort(Stack<ITypedToken> stack, Queue<IEvaluatableToken> output);
    }
}
