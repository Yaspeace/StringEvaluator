using StringEvaluatorDesktop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEvaluatorDesktop.Errors
{
    public static class EvaluateErrors
    {
        public static readonly EvaluateException InputStringIsEmpty = new EvaluateException("Логин или пароль не может быть пустым");
        public static readonly EvaluateException BracketIsNotClosed = new EvaluateException("Одна из скобок не закрыта");
    }
}
