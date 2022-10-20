namespace StringEvaluatorDesktop.StringEvaluator.Models.Variables
{
    public class Variable : IVariable
    {
        public string Name { get; set; }
        public double Value => _value;

        private double _value;

        public Variable(string name, double value)
        {
            Name = name;
            _value = value;
        }
    }
}
