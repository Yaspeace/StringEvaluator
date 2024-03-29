﻿using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class TanToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Tan(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input.Length - position >= 2 && input.Substring(position, 2) == "tg")
            {
                token = new TanToken();
                return 2;
            }
            if (input.Length - position >= 3 && input.Substring(position, 3) == "tan")
            {
                token = new TanToken();
                return 3;
            }
            token = null;
            return -1;
        }
    }
}
