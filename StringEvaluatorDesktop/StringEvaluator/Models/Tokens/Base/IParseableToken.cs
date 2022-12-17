namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base
{
    public interface IParseableToken
    {
        int Parse(string input, int position, out ITypedToken? token);
    }
}
