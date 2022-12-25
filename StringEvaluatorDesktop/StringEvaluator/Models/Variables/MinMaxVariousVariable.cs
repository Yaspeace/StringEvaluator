namespace StringEvaluatorDesktop.StringEvaluator.Models.Variables
{
    public class MinMaxVariousVariable : IVariousVariable
    {
        public int StepsCount => _stepsCount;

        public int CurrentStep => _curStep;

        public string Name { get; set; }

        public double Value
        {
            get
            {
                var step = (_finalVal - _initVal) / _stepsCount;
                return _initVal + (step * _curStep);
            }
        }

        private double _initVal;

        private double _finalVal;

        private int _stepsCount;

        private int _curStep;

        public MinMaxVariousVariable(string name, double initVal, double finVal, int stepsCount)
        {
            Name = name;
            _initVal = initVal;
            _finalVal = finVal;
            _stepsCount = stepsCount;
            _curStep = 0;
        }

        public bool Next()
        {
            if (CurrentStep >= StepsCount) return false;
            _curStep++;
            return true;
        }
    }
}
