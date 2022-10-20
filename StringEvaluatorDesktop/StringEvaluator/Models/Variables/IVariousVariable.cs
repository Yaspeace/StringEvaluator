namespace StringEvaluatorDesktop.StringEvaluator.Models.Variables
{
    public interface IVariousVariable : IVariable
    {
        void Next();
        int StepsCount { get; }
        int CurrentStep { get; }
    }
}
