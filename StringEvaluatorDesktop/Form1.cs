using SortStation_CS;

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
        }
    }
}