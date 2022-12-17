using SortStation_CS;
using StringEvaluatorDesktop.StringEvaluator;
using StringEvaluatorDesktop.StringEvaluator.Helpers;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;
using StringEvaluatorDesktop.StringEvaluator.Models.Variables;

namespace StringEvaluatorDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(xValueTb.Text, out var x))
                MessageBox.Show("Ошибка: не удается считать значение переменной X!", "ОШИБКА");
            if (!double.TryParse(yValueTb.Text, out var y))
                MessageBox.Show("Ошибка: не удается считать значение переменной Y!", "ОШИБКА");
            //resultLbl.Text = new Formulas().Evaluate(expressionTb.Text, x, y).ToString();

            var variables = new Variable[]
            {
                new Variable("x", x),
                new Variable("y", y)
            };
            var expr = new Expression(expressionTb.Text, variables);
            resultLbl.Text = expr.Evaluate().ToString();
        }
    }
}