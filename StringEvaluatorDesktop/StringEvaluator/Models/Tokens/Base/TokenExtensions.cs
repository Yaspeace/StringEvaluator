namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base
{
    public static class TokenExtensions
    {
        public static IEvaluatableToken AsEvaluatable(this ITypedToken token)
        {
            return (token as IEvaluatableToken) 
                ?? throw new Exception($"Токен {token.GetType().Name} не вычисляемый");
        }
    }
}
