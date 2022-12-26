using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEvaluatorDesktop.Exceptions
{
    public class EvaluateException : Exception
    {
        public string ErrorMessage { get; set; }
        public EvaluateException() { }
        public EvaluateException(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
