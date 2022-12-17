using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class UnaryMinusToken : OperatorToken, IParseableToken, IEvaluatableToken
    {
        public override int Priority => 3;

        public override bool IsLeftAssociated => false;

        public void Evaluate(Stack<double> stack)
        {
            stack.Push(-stack.Pop());
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if ((position == 0 || input[position - 1] == '(') && input[position] == '-')
            {
                token = new UnaryMinusToken();
                return 1;
            }
            token = null;
            return -1;
        }
    }
}
