using StringEvaluatorDesktop.StringEvaluator.Models.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEvaluatorDesktop.StringEvaluator.Helpers
{
    /// <summary>
    /// Класс для преобразования входной строки в очередь токенов вида ОПЗ
    /// </summary>
    public class ExpressionModifier
    {
        public Queue<IToken> Modify(string expression)
        {
            return new Queue<IToken>();
        }
    }
}
