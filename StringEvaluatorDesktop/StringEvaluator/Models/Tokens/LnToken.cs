using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class LnToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Log(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            token = new LnToken();
            if (input.Length - position > 2 && input.Substring(position, 2) == "ln") return 2;
            return -1;
        }
    }
}
