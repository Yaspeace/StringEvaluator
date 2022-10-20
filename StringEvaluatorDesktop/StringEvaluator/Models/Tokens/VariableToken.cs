using StringEvaluatorDesktop.StringEvaluator.Models.Variables;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class VariableToken : IToken
    {
        private string name;

        private Dictionary<string, IVariable> variables;

        public int Priority => 0;

        public VariableToken(string variableName, Dictionary<string, IVariable> variables)
        {
            name = variableName;
            this.variables = variables;
        }

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(variables[name].Value);
        }
    }
}
