namespace StringEvaluatorDesktop.StringEvaluator.Models.Variables
{
    public class StepVariousVariable : IVariousVariable
    {
        public string Name { get; set; }

        public double Value => _currentValue;

        public int StepsCount => _stepsCount;

        public int CurrentStep => _curStep;

        private double _currentValue;

        private int _stepsCount;

        private int _curStep;

        private double _step;

        public StepVariousVariable(string name, double initValue, double step, int stepsCount)
        {
            Name = name;
            _currentValue = initValue;
            _step = step;
            _stepsCount = stepsCount;
            _curStep = 0;
        }

        public bool Next()
        {
            if (CurrentStep >= StepsCount) return false;
            _curStep++;
            _currentValue += _step;
            return true;
        }
    }
}
