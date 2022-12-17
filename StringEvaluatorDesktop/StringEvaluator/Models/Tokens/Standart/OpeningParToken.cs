using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart
{
    public class OpeningParToken : ITypedToken, IParseableToken
    {
        public TokenTypes Type => TokenTypes.OpeningPar;

        public int Parse(string input, int position, out ITypedToken? token)
        {
            token = new OpeningParToken();
            if (input[position] == '(') return 1;
            return -1;
        }

        public void Sort(Stack<ITypedToken> stack, Queue<IEvaluatableToken> output) => stack.Push(this);
    }
}
