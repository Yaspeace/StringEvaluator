﻿namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class SinToken : IToken
    {
        public int Priority => 3;

        public void PerformOperation(Stack<double> stack)
        {
            stack.Push(Math.Sin(stack.Pop()));
        }
    }
}
