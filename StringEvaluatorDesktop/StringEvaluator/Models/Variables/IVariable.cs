namespace StringEvaluatorDesktop.StringEvaluator.Models.Variables
{
    public interface IVariable
    {
        string Name { get; set; }
        double Value { get; }
    }
}
