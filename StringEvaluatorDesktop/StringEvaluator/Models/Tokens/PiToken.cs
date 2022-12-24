using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class PiToken : ParameterToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.PI);
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input.Length - position >= 2 && input.Substring(position, 2).ToLower() == "pi")
            {
                token = new PiToken();
                return 2;
            }
            token = null;
            return -1;
        }
    }
}
