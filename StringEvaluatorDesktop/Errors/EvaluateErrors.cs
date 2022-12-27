using StringEvaluatorDesktop.Exceptions;

namespace StringEvaluatorDesktop.Errors
{
    public static class EvaluateErrors
    {
        public static readonly EvaluateException InputStringIsEmpty = new EvaluateException("Выражение не введено");
        public static readonly EvaluateException BracketIsNotClosed = new EvaluateException("В выражении присутствуют незакрытые скобки");
        public static readonly EvaluateException IncorrectExpression = new EvaluateException("Не удается вычислить введенное выражение");
    }
}
