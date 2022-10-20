using StringEvaluatorDesktop.StringEvaluator.Models.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEvaluatorDesktop.StringEvaluator
{
    public class Evaluator
    {
        public double Evaluate(string expression, IEnumerable<IVariable> variables)
        {
            return 0;
        }

        public IEnumerable<double> EvaluateMany(string expression, IEnumerable<IVariousVariable> variables)
        {
            var steps = variables.First().StepsCount;
            var result = new List<double>();
            for(int i = 0; i < steps; i++)
            {
                result.Add(0);
                foreach (var v in variables) v.Next();
            }
            return result;
        }
    }
}
