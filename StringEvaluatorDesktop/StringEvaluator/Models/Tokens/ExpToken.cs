using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class ExpToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Exp(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input.Length - position >= 3 && input.Substring(position, 3) == "exp")
            {
                token = new ExpToken();
                return 3;
            }
            token = null;
            return -1;
        }
    }
}
