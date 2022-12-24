using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class ArctgToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Atan(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (Check(input, position, "atan"))
            {
                token = new ArctgToken();
                return 4;
            }
            if (Check(input, position, "arctg"))
            {
                token = new ArctgToken();
                return 5;
            }
            if (Check(input, position, "arctan"))
            {
                token = new ArctgToken();
                return 6;
            }
            token = null;
            return -1;
        }

        private bool Check(string inp, int pos, string str)
        {
            return inp.Length - pos >= str.Length && inp.Substring(pos, str.Length) == str;
        }
    }
}
