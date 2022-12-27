using OxyPlot;
using OxyPlot.Series;
using StringEvaluatorDesktop.Controllers;
using StringEvaluatorDesktop.Controls;
using StringEvaluatorDesktop.Exceptions;

namespace StringEvaluatorDesktop
{
    public partial class MainForm : Form
    {
        private List<VariableInput> variableInputs = new List<VariableInput>();

        private readonly EvaluatorController _controller;

        private LineSeries _plotSeries;

        public MainForm()
        {
            _controller = new EvaluatorController();

            InitializeComponent();

            _plotSeries = new LineSeries();
            mainChart.Model = new PlotModel();
            mainChart.Model.Series.Add(_plotSeries);
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultLbl.Text = _controller.GetSolution(expressionTb.Text, variableInputs.Select(x => x.Value)).ToString();
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show($"Ошибка при вычислении выражения: {ex.Message}");
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка в работе приложения", "Что-то пошло не так...");
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

        private void expressionTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                solveBtn_Click(sender, e);
        }

        private void NumBtnClicked(object? btn, EventArgs _)
        {
            if (btn == null) return;
            expressionTb.Text += ((Button)btn)?.Text;
        }

        private void FuncBtnClicked(object? btn, EventArgs _)
        {
            if (btn == null) return;
            expressionTb.Text += ((Button)btn)?.Text + "(";
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(expressionTb.Text))
                expressionTb.Text = expressionTb.Text.Substring(0, expressionTb.Text.Length - 1);
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            expressionTb.Text = string.Empty;
        }

        private void refreshChartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _plotSeries.Points.Clear();

                int n = (int)countNud.Value;
                double min = (double)argumentMinNud.Value;
                double max = (double)argumentMaxNud.Value;
                var argumentName = argumentNameTb.Text;
                var parameters = variableInputs.Select(x => x.Value).Where(x => x.Name != argumentName);

                var newPoints = _controller.GetFuncSolution(
                    expressionTb.Text,
                    argumentName,
                    min,
                    max,
                    n,
                    parameters);
                foreach (var point in newPoints)
                    _plotSeries.Points.Add(new DataPoint(point.x, point.y));
                mainChart.Refresh();
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show($"Ошибка при вычислении выражения: {ex.Message}");
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка в работе приложения", "Что-то пошло не так...");
            }
        }
    }
}