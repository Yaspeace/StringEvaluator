using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class MinusToken : OperatorToken, IParseableToken, IEvaluatableToken
    {
        public override int Priority => 1;

        public override bool IsLeftAssociated => true;

        public void Evaluate(Stack<double> stack)
        {
            var rOperand = stack.Pop();
            var lOperand = stack.Pop();
            stack.Push(lOperand - rOperand);
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            token = new MinusToken();
            if (input[position] == '-') return 1;
            return -1;
        }
    }
}
