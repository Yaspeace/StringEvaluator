namespace StringEvaluatorDesktop.Exceptions
{
    public class ParsingException : EvaluateException
    {
        public ParsingException(char symbol) : base($"Неизвестный символ '{symbol}'") { }
    }
}
