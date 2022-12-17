using StringEvaluatorDesktop.StringEvaluator.Models.Tokens;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;
using StringEvaluatorDesktop.StringEvaluator.Models.Variables;

namespace StringEvaluatorDesktop.StringEvaluator.Helpers
{
    public class Parser
    {
        private IEnumerable<IVariable> variables;

        private IEnumerable<IParseableToken> tokens;

        public Parser(IEnumerable<IVariable> variables)
        {
            this.variables = variables;
            tokens = InitTokens();
        }

        private IEnumerable<IParseableToken> InitTokens()
        {
            var res = new List<IParseableToken>();

            foreach (var variable in variables)
                res.Add(new VariableToken(variable));

            #region AllTokens
            res.Add(new OpeningParToken());
            res.Add(new ClosingParToken());

            res.Add(new UnaryMinusToken());
            res.Add(new MinusToken());
            res.Add(new PlusToken());
            res.Add(new MultiplyToken());
            res.Add(new DivideToken());
            res.Add(new PowToken());

            res.Add(new SinToken());
            res.Add(new CosToken());
            res.Add(new TanToken());
            res.Add(new LnToken());
            res.Add(new SqrtToken());

            res.Add(new NumberToken());
            #endregion

            return res;
        }

        public IEnumerable<ITypedToken> Parse(string input)
        {
            var res = new List<ITypedToken>();
            int position = 0;
            while (position < input.Length)
            {
                bool parsed = false;
                foreach (var t in tokens)
                {
                    int parsingResult = t.Parse(input, position, out var newToken);
                    if (parsingResult > -1 && newToken != null)
                    {
                        res.Add(newToken);
                        position += parsingResult;
                        parsed = true;
                        break;
                    }
                }

                if(!parsed)
                    throw new Exception($"Не удаётся спарсить начало строки \"{input.Substring(position)}\"");
            }
            return res;
        }
    }
}
