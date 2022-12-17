using SortStation_CS;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Base;
using StringEvaluatorDesktop.StringEvaluator.Models.Tokens.Standart;

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
            resultLbl.Text = new Formulas().Evaluate(expressionTb.Text, x, y).ToString();

            var test = "123.45";
            var tok = new NumberToken(0);
            int res = tok.Parse(test, 0, out var newTok);
            var test1 = newTok;

        }
    }
}