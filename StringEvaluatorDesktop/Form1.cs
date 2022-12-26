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

            numBtn1.Click += NumBtnClicked;
            numBtn2.Click += NumBtnClicked;
            numBtn3.Click += NumBtnClicked;
            numBtn4.Click += NumBtnClicked;
            numBtn5.Click += NumBtnClicked;
            numBtn6.Click += NumBtnClicked;
            numBtn7.Click += NumBtnClicked;
            numBtn8.Click += NumBtnClicked;
            numBtn9.Click += NumBtnClicked;
            numBtn10.Click += NumBtnClicked;
            numBtn11.Click += NumBtnClicked;
            numBtn12.Click += NumBtnClicked;

            opBtn1.Click += NumBtnClicked;
            opBtn2.Click += NumBtnClicked;
            opBtn3.Click += NumBtnClicked;
            opBtn4.Click += NumBtnClicked;
            opBtn5.Click += NumBtnClicked;

            constBtn1.Click += NumBtnClicked;
            constBtn2.Click += NumBtnClicked;

            funcBtn1.Click += FuncBtnClicked;
            funcBtn2.Click += FuncBtnClicked;
            funcBtn3.Click += FuncBtnClicked;
            funcBtn4.Click += FuncBtnClicked;
            funcBtn5.Click += FuncBtnClicked;
            funcBtn6.Click += FuncBtnClicked;
            funcBtn7.Click += FuncBtnClicked;
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
                MessageBox.Show(ex.Message, "Что-то пошло не так...");
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