using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart
{
    public abstract class FunctionToken : ITypedToken
    {
        public TokenTypes Type => TokenTypes.Function;

        public void Sort(Stack<ITypedToken> stack, Queue<IEvaluatableToken> output) => stack.Push(this);
    }
}
