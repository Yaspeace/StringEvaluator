using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEvaluatorDesktop.Exceptions
{
    public class EvaluateException : Exception
    {
        public EvaluateException(string errorMessage) : base(errorMessage) { }
    }
}
