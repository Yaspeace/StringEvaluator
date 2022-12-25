namespace StringEvaluatorDesktop.StringEvaluator.Models.Variables
{
    public interface IVariousVariable : IVariable
    {
        bool Next();
        int StepsCount { get; }
        int CurrentStep { get; }
    }
}
