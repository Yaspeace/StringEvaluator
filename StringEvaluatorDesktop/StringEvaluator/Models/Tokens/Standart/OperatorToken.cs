using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart
{
    public abstract class OperatorToken : ITypedToken
    {
        public TokenTypes Type => TokenTypes.Operator;

        public abstract int Priority { get; }

        public abstract bool IsLeftAssociated { get; }

        public void Sort(Stack<ITypedToken> stack, Queue<IEvaluatableToken> output)
        {
            ITypedToken top;
            while (stack.Count > 0 && (top = stack.Peek()).Type == TokenTypes.Operator
                && ((IsLeftAssociated && Priority <= AsOperator(top).Priority)
                    || (!IsLeftAssociated && Priority < AsOperator(top).Priority)))
            {
                output.Enqueue(stack.Pop().AsEvaluatable());
            }
            stack.Push(this);
        }

        private OperatorToken AsOperator(ITypedToken token)
        {
            return (token as OperatorToken) ?? throw new InvalidOperationException("Непреобразуемый токен");
        }
    }
}
