using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class CosToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Cos(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            token = new CosToken();
            if (input.Length - position >= 3 && input.Substring(position, 3) == "cos") return 3;
            return -1;
        }
    }
}
