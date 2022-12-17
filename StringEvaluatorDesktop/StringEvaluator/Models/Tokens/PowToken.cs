using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class PowToken : OperatorToken, IParseableToken, IEvaluatableToken
    {
        public override int Priority => 2;

        public override bool IsLeftAssociated => false;

        public void Evaluate(Stack<double> stack)
        {
            var rOperand = stack.Pop();
            var lOperand = stack.Pop();
            stack.Push(Math.Pow(lOperand, rOperand));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input[position] == '*')
            {
                token = new PowToken();
                return 1;
            }
            token = null;
            return -1;
        }
    }
}
