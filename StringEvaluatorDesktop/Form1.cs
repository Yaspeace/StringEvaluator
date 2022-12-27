using StringEvaluatorDesktop.Controllers;
using StringEvaluatorDesktop.Controls;
using StringEvaluatorDesktop.Exceptions;

namespace StringEvaluatorDesktop
{
    public partial class MainForm : Form
    {
        private List<VariableInput> variableInputs = new List<VariableInput>();

        private readonly EvaluatorController _controller;

        public MainForm()
        {
            _controller = new EvaluatorController();

            InitializeComponent();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultLbl.Text = _controller.GetSolution(expressionTb.Text, variableInputs.Select(x => x.Value)).ToString();
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show($"������ ��� ���������� ���������: {ex.Message}");
            }
            catch
            {
                MessageBox.Show("��������� �������������� ������ � ������ ����������", "���-�� ����� �� ���...");
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
    }
}