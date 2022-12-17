using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

namespace StringEvaluatorDesktop.StringEvaluator.Models.Tokens
{
    public class NumberToken : ParameterToken, IParseableToken, IEvaluatableToken
    {
        private double value;

        public NumberToken() { }

        public NumberToken(double value)
        {
            this.value = value;
        }

        public void Evaluate(Stack<double> stack)
        {
            stack.Push(value);
        }

        public int Parse(string input, int position, out ITypedToken? token)
        {
            bool dot = false;
            string number = string.Empty;
            if (input[position] == '.')
            {
                dot = true;
                number = "0,";
                position++;
            }

            while (position < input.Length && input[position] >= '0' && input[position] <= '9') number += input[position++];
            
            if (number == string.Empty)
            {
                token = null;
                return -1;
            }
            if (position == input.Length)
            {
                token = new NumberToken(double.Parse(number));
                return number.Length;
            }

            if (!dot && input[position] == '.')
            {
                number += ",";
                position++;
                while (position < input.Length && input[position] >= '0' && input[position] <= '9') number += input[position++];
            }

            if (position < input.Length && (input[position] == 'e' || input[position] == 'E'))
            {
                number += input[position];
                position++;
                if (input[position] == '-' || input[position] == '+') number += input[position];
                while (position < input.Length && input[position] >= '0' && input[position] <= '9') number += input[position++];
            }

            if (double.TryParse(number, out var res))
            {
                token = new NumberToken(res);
                return number.Length;
            }
            token = null;
            return -1;
        }
    }
}
