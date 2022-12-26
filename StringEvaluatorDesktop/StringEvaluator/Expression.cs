using StringEvaluatorDesktop.Errors;
using StringEvaluatorDesktop.Exceptions;
using StringEvaluatorDesktop.StringEvaluator.Helpers;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Variables;

namespace StringEvaluatorDesktop.StringEvaluator
{
    public class Expression
    {
        private IEnumerable<ITypedToken> tokenExpression;

        private IEnumerable<IEvaluatableToken>? rpnExpression = null;

        private Parser parser;

        public Expression(string expr, IEnumerable<IVariable> variables)
        {
            parser = new Parser(variables);
            tokenExpression = parser.Parse(expr);
        }

        public double Evaluate()
        {
            if (rpnExpression == null) rpnExpression = ConvertToRpn(tokenExpression);
            var resultStack = new Stack<double>();
            foreach (var token in rpnExpression) token.Evaluate(resultStack);
            return resultStack.Pop();
        }

        private IEnumerable<IEvaluatableToken> ConvertToRpn(IEnumerable<ITypedToken> expr)
        {
            var stack = new Stack<ITypedToken>();
            var output = new Queue<IEvaluatableToken>();
            foreach (var token in expr) token.Sort(stack, output);
            while (stack.Count > 0)
            {
                var token = stack.Pop();
                if (token.Type == TokenTypes.OpeningPar || token.Type == TokenTypes.ClosingPar)
                    throw EvaluateErrors.BracketIsNotClosed;
                output.Enqueue(token.AsEvaluatable());
            }
            return output;
        }
    }
}
