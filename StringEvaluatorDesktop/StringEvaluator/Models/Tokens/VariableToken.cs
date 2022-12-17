using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;
using StringEvaluatorDesktop.StringEvaluator.Models.Variables;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class VariableToken : ParameterToken, IParseableToken, IEvaluatableToken
    {
        private IVariable variable;

        public VariableToken() { }

        public VariableToken(IVariable variable)
        {
            this.variable = variable;
        }

        public void Evaluate(Stack<double> stack)
        {
            stack.Push(variable.Value);
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input.Length - position >= variable.Name.Length
                && input.Substring(position, variable.Name.Length) == variable.Name)
            {
                token = new VariableToken(variable);
                return variable.Name.Length;
            }
            token = null;
            return -1;
        }
    }
}
