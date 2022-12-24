using StringEvaluatorDesktop.StringEvaluator.Models.Variables;

namespace StringEvaluatorDesktop.Controls
{
    public partial class VariableInput : UserControl
    {
        public string VariableName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public double VariableValue
        {
            get => (double)valueNud.Value;
            set => valueNud.Value = (decimal)value;
        }

        public Variable Value
        {
            get
            {
                return new Variable(nameTextBox.Text, (double)valueNud.Value);
            }
        }

        public VariableInput()
        {
            InitializeComponent();
        }
    }
}
