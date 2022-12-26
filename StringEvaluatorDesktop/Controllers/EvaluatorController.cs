using StringEvaluatorDesktop.Errors;
using StringEvaluatorDesktop.StringEvaluator;
using StringEvaluatorDesktop.StringEvaluator.Models.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEvaluatorDesktop.Controllers
{
    public class EvaluatorController
    {

        public double GetSolution(string expression, IEnumerable<IVariable> variables)
        {
            if (string.IsNullOrEmpty(expression)) throw EvaluateErrors.InputStringIsEmpty;
            var expr = new Expression(expression, variables);
            return expr.Evaluate();
        }
    }
}
