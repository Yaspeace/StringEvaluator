using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class EToken : ParameterToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.E);
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input[position] == 'e' || input[position] == 'E')
            {
                token = new EToken();
                return 1;
            }
            token = null;
            return -1;
        }
    }
}
