using StringEvaluatorDesktop.Controls;
using StringEvaluatorDesktop.StringEvaluator;

namespace StringEvaluatorDesktop
{
    public partial class MainForm : Form
    {
        private List<VariableInput> variableInputs = new List<VariableInput>();

        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(addVarBtn);
            flowLayoutPanel1.Controls.Add(removeVarBtn);
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var variables = variableInputs.Select(x => x.Value);
                var expr = new Expression(expressionTb.Text, variables);
                resultLbl.Text = expr.Evaluate().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Œÿ»¡ ¿");
            }
        }

        private void addVarBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(addVarBtn);
            flowLayoutPanel1.Controls.Remove(removeVarBtn);
            var newInp = new VariableInput();
            variableInputs.Add(newInp);
            flowLayoutPanel1.Controls.Add(newInp);
            flowLayoutPanel1.Controls.Add(addVarBtn);
            flowLayoutPanel1.Controls.Add(removeVarBtn);
        }

        private void removeVarBtn_Click(object sender, EventArgs e)
        {
            var last = variableInputs.Last();
            variableInputs.Remove(last);
            flowLayoutPanel1.Controls.Remove(last);
            last.Dispose();
        }
    }
}