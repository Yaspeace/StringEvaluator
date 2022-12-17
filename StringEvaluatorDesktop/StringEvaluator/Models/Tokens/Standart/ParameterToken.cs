using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart
{
    public abstract class ParameterToken : ITypedToken
    {
        public TokenTypes Type => TokenTypes.Parameter;

        public void Sort(Stack<ITypedToken> stack, Queue<IEvaluatableToken> output) => output.Enqueue(this.AsEvaluatable());
    }
}
