using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class MultiplyToken : OperatorToken, IParseableToken, IEvaluatableToken
    {
        public override int Priority => 2;

        public override bool IsLeftAssociated => true;

        public void Evaluate(Stack<double> stack)
        {
            stack.Push(stack.Pop() * stack.Pop());
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            token = new MultiplyToken();
            if (input[position] == '*') return 1;
            return -1;
        }
    }
}
