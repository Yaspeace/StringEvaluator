using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart
{
    public class ClosingParToken : ITypedToken, IParseableToken
    {
        public TokenTypes Type => TokenTypes.ClosingPar;

        public int Parse(string input, int position, out ITypedToken? token)
        {
            token = new ClosingParToken();
            if (input[position] == ')') return 1;
            return -1;
        }

        public void Sort(Stack<ITypedToken> stack, Queue<IEvaluatableToken> output)
        {
            var top = stack.Pop();
            while (top.Type != TokenTypes.OpeningPar)
            {
                output.Enqueue(top.AsEvaluatable());
                if (!stack.TryPop(out top)) throw new Exception("В выражении пропущена скобка");
            }
            if (stack.Count > 0 && stack.Peek().Type == TokenTypes.Function)
                output.Enqueue(stack.Pop().AsEvaluatable());
        }
    }
}
