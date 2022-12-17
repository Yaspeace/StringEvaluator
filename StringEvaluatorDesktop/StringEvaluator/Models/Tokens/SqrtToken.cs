using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class SqrtToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Sqrt(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input.Length - position >= 4 && input.Substring(position, 4) == "sqrt")
            {
                token = new SqrtToken();
                return 4;
            }
            token = null;
            return -1;
        }
    }
}
