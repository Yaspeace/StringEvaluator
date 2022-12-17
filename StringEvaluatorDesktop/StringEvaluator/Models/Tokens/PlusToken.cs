using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class PlusToken : OperatorToken, IParseableToken, IEvaluatableToken
    {
        public override int Priority => 1;

        public override bool IsLeftAssociated => true;

        public void Evaluate(Stack<double> stack)
        {
            var rOperand = stack.Pop();
            var lOperand = stack.Pop();
            stack.Push(rOperand + lOperand);
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input[position] == '+')
            {
                token = new PlusToken();
                return 1;
            }
            token = null;
            return -1;
        }
    }
}
