﻿using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class SinToken : FunctionToken, IParseableToken, IEvaluatableToken
    {
        public void Evaluate(Stack<double> stack)
        {
            stack.Push(Math.Sin(stack.Pop()));
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            if (input.Length - position >= 3 && input.Substring(position, 3) == "sin")
            {
                token = new SinToken();
                return 3;
            }
            token = null;
            return -1;
        }
    }
}
