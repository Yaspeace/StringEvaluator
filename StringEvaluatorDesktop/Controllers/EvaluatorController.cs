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

        /// <summary>
        /// Метод вычисления значения выражения
        /// </summary>
        /// <param name="expression">Выражение</param>
        /// <param name="variables">Коллекция значений параметров</param>
        /// <returns>Значение выражения</returns>
        public double GetSolution(string expression, IEnumerable<IVariable> variables)
        {
            if (string.IsNullOrEmpty(expression)) throw EvaluateErrors.InputStringIsEmpty;
            var expr = new Expression(expression, variables);
            return expr.Evaluate();
        }

        /// <summary>
        /// Метод вычисления выражения N раз с изменением переменной
        /// </summary>
        /// <param name="expression">Строка с выражением</param>
        /// <param name="argName">Имя аргумента функции</param>
        /// <param name="minValue">Минимальное значение аргумента функции</param>
        /// <param name="maxValue">максимальное значение аргумента функции</param>
        /// <param name="N">Кол-во вычислений функции </param>
        /// <param name="variables">Параметры графика функции</param>
        /// <returns>Коллекция значений функции</returns>
        public IEnumerable<(double x, double y)> GetFuncSolution(string expression, string argName, double minValue, double maxValue, int N, IEnumerable<IVariable> variables)
        {
            var minMaxVariousVariable = new MinMaxVariousVariable(argName, minValue, maxValue, N);
            var list = new List<IVariable>
            {
                minMaxVariousVariable
            };
            list.AddRange(variables);
            var result = new List<(double, double)>();
            var expr = new Expression(expression, list);
            while (minMaxVariousVariable.Next())
            {
                result.Add((minMaxVariousVariable.Value, expr.Evaluate()));
            }
            return result;
        }
    }
}
