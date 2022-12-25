namespace StringEvaluatorDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.expressionTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addVarBtn = new System.Windows.Forms.Button();
            this.removeVarBtn = new System.Windows.Forms.Button();
            this.numBtn1 = new System.Windows.Forms.Button();
            this.numBtn2 = new System.Windows.Forms.Button();
            this.numBtn3 = new System.Windows.Forms.Button();
            this.numBtn4 = new System.Windows.Forms.Button();
            this.numBtn5 = new System.Windows.Forms.Button();
            this.numBtn6 = new System.Windows.Forms.Button();
            this.numBtn7 = new System.Windows.Forms.Button();
            this.numBtn8 = new System.Windows.Forms.Button();
            this.numBtn9 = new System.Windows.Forms.Button();
            this.numBtn10 = new System.Windows.Forms.Button();
            this.opBtn1 = new System.Windows.Forms.Button();
            this.opBtn2 = new System.Windows.Forms.Button();
            this.opBtn3 = new System.Windows.Forms.Button();
            this.opBtn4 = new System.Windows.Forms.Button();
            this.opBtn5 = new System.Windows.Forms.Button();
            this.funcBtn1 = new System.Windows.Forms.Button();
            this.funcBtn2 = new System.Windows.Forms.Button();
            this.funcBtn3 = new System.Windows.Forms.Button();
            this.funcBtn4 = new System.Windows.Forms.Button();
            this.funcBtn5 = new System.Windows.Forms.Button();
            this.funcBtn6 = new System.Windows.Forms.Button();
            this.constBtn1 = new System.Windows.Forms.Button();
            this.funcBtn7 = new System.Windows.Forms.Button();
            this.constBtn2 = new System.Windows.Forms.Button();
            this.numBtn11 = new System.Windows.Forms.Button();
            this.numBtn12 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "Переменные:";
            // 
            // expressionTb
            // 
            this.expressionTb.Location = new System.Drawing.Point(92, 6);
            this.expressionTb.Name = "expressionTb";
            this.expressionTb.Size = new System.Drawing.Size(350, 23);
            this.expressionTb.TabIndex = 0;
            this.expressionTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.expressionTb_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выражение:";
            // 
            // solveBtn
            // 
            this.solveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.solveBtn.Location = new System.Drawing.Point(448, 6);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(68, 23);
            this.solveBtn.TabIndex = 2;
            this.solveBtn.Text = "=";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLbl.Location = new System.Drawing.Point(522, 10);
            this.resultLbl.MaximumSize = new System.Drawing.Size(100, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(12, 15);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "?";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.addVarBtn);
            this.flowLayoutPanel1.Controls.Add(this.removeVarBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 354);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // addVarBtn
            // 
            this.addVarBtn.Location = new System.Drawing.Point(3, 3);
            this.addVarBtn.Name = "addVarBtn";
            this.addVarBtn.Size = new System.Drawing.Size(98, 23);
            this.addVarBtn.TabIndex = 9;
            this.addVarBtn.Text = "Добавить";
            this.addVarBtn.UseVisualStyleBackColor = true;
            this.addVarBtn.Click += new System.EventHandler(this.addVarBtn_Click);
            // 
            // removeVarBtn
            // 
            this.removeVarBtn.Location = new System.Drawing.Point(107, 3);
            this.removeVarBtn.Name = "removeVarBtn";
            this.removeVarBtn.Size = new System.Drawing.Size(98, 23);
            this.removeVarBtn.TabIndex = 10;
            this.removeVarBtn.Text = "Убрать";
            this.removeVarBtn.UseVisualStyleBackColor = true;
            this.removeVarBtn.Click += new System.EventHandler(this.removeVarBtn_Click);
            // 
            // numBtn1
            // 
            this.numBtn1.Location = new System.Drawing.Point(364, 53);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(46, 23);
            this.numBtn1.TabIndex = 9;
            this.numBtn1.Text = "1";
            this.numBtn1.UseVisualStyleBackColor = true;
            // 
            // numBtn2
            // 
            this.numBtn2.Location = new System.Drawing.Point(416, 53);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(46, 23);
            this.numBtn2.TabIndex = 10;
            this.numBtn2.Text = "2";
            this.numBtn2.UseVisualStyleBackColor = true;
            // 
            // numBtn3
            // 
            this.numBtn3.Location = new System.Drawing.Point(468, 53);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(46, 23);
            this.numBtn3.TabIndex = 11;
            this.numBtn3.Text = "3";
            this.numBtn3.UseVisualStyleBackColor = true;
            // 
            // numBtn4
            // 
            this.numBtn4.Location = new System.Drawing.Point(364, 82);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(46, 23);
            this.numBtn4.TabIndex = 12;
            this.numBtn4.Text = "4";
            this.numBtn4.UseVisualStyleBackColor = true;
            // 
            // numBtn5
            // 
            this.numBtn5.Location = new System.Drawing.Point(416, 82);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(46, 23);
            this.numBtn5.TabIndex = 13;
            this.numBtn5.Text = "5";
            this.numBtn5.UseVisualStyleBackColor = true;
            // 
            // numBtn6
            // 
            this.numBtn6.Location = new System.Drawing.Point(468, 82);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(46, 23);
            this.numBtn6.TabIndex = 14;
            this.numBtn6.Text = "6";
            this.numBtn6.UseVisualStyleBackColor = true;
            // 
            // numBtn7
            // 
            this.numBtn7.Location = new System.Drawing.Point(364, 111);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(46, 23);
            this.numBtn7.TabIndex = 15;
            this.numBtn7.Text = "7";
            this.numBtn7.UseVisualStyleBackColor = true;
            // 
            // numBtn8
            // 
            this.numBtn8.Location = new System.Drawing.Point(416, 111);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(46, 23);
            this.numBtn8.TabIndex = 16;
            this.numBtn8.Text = "8";
            this.numBtn8.UseVisualStyleBackColor = true;
            // 
            // numBtn9
            // 
            this.numBtn9.Location = new System.Drawing.Point(468, 111);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(46, 23);
            this.numBtn9.TabIndex = 17;
            this.numBtn9.Text = "9";
            this.numBtn9.UseVisualStyleBackColor = true;
            // 
            // numBtn10
            // 
            this.numBtn10.Location = new System.Drawing.Point(416, 140);
            this.numBtn10.Name = "numBtn10";
            this.numBtn10.Size = new System.Drawing.Size(46, 23);
            this.numBtn10.TabIndex = 18;
            this.numBtn10.Text = "0";
            this.numBtn10.UseVisualStyleBackColor = true;
            // 
            // opBtn1
            // 
            this.opBtn1.Location = new System.Drawing.Point(543, 53);
            this.opBtn1.Name = "opBtn1";
            this.opBtn1.Size = new System.Drawing.Size(46, 23);
            this.opBtn1.TabIndex = 19;
            this.opBtn1.Text = "+";
            this.opBtn1.UseVisualStyleBackColor = true;
            // 
            // opBtn2
            // 
            this.opBtn2.Location = new System.Drawing.Point(543, 82);
            this.opBtn2.Name = "opBtn2";
            this.opBtn2.Size = new System.Drawing.Size(46, 23);
            this.opBtn2.TabIndex = 20;
            this.opBtn2.Text = "-";
            this.opBtn2.UseVisualStyleBackColor = true;
            // 
            // opBtn3
            // 
            this.opBtn3.Location = new System.Drawing.Point(543, 111);
            this.opBtn3.Name = "opBtn3";
            this.opBtn3.Size = new System.Drawing.Size(46, 23);
            this.opBtn3.TabIndex = 21;
            this.opBtn3.Text = "*";
            this.opBtn3.UseVisualStyleBackColor = true;
            // 
            // opBtn4
            // 
            this.opBtn4.Location = new System.Drawing.Point(543, 140);
            this.opBtn4.Name = "opBtn4";
            this.opBtn4.Size = new System.Drawing.Size(46, 23);
            this.opBtn4.TabIndex = 22;
            this.opBtn4.Text = "/";
            this.opBtn4.UseVisualStyleBackColor = true;
            // 
            // opBtn5
            // 
            this.opBtn5.Location = new System.Drawing.Point(543, 169);
            this.opBtn5.Name = "opBtn5";
            this.opBtn5.Size = new System.Drawing.Size(46, 23);
            this.opBtn5.TabIndex = 23;
            this.opBtn5.Text = "^";
            this.opBtn5.UseVisualStyleBackColor = true;
            // 
            // funcBtn1
            // 
            this.funcBtn1.Location = new System.Drawing.Point(364, 190);
            this.funcBtn1.Name = "funcBtn1";
            this.funcBtn1.Size = new System.Drawing.Size(46, 23);
            this.funcBtn1.TabIndex = 24;
            this.funcBtn1.Text = "sqrt";
            this.funcBtn1.UseVisualStyleBackColor = true;
            // 
            // funcBtn2
            // 
            this.funcBtn2.Location = new System.Drawing.Point(416, 190);
            this.funcBtn2.Name = "funcBtn2";
            this.funcBtn2.Size = new System.Drawing.Size(46, 23);
            this.funcBtn2.TabIndex = 25;
            this.funcBtn2.Text = "ln";
            this.funcBtn2.UseVisualStyleBackColor = true;
            // 
            // funcBtn3
            // 
            this.funcBtn3.Location = new System.Drawing.Point(364, 219);
            this.funcBtn3.Name = "funcBtn3";
            this.funcBtn3.Size = new System.Drawing.Size(46, 23);
            this.funcBtn3.TabIndex = 26;
            this.funcBtn3.Text = "sin";
            this.funcBtn3.UseVisualStyleBackColor = true;
            // 
            // funcBtn4
            // 
            this.funcBtn4.Location = new System.Drawing.Point(416, 219);
            this.funcBtn4.Name = "funcBtn4";
            this.funcBtn4.Size = new System.Drawing.Size(46, 23);
            this.funcBtn4.TabIndex = 27;
            this.funcBtn4.Text = "cos";
            this.funcBtn4.UseVisualStyleBackColor = true;
            // 
            // funcBtn5
            // 
            this.funcBtn5.Location = new System.Drawing.Point(468, 219);
            this.funcBtn5.Name = "funcBtn5";
            this.funcBtn5.Size = new System.Drawing.Size(46, 23);
            this.funcBtn5.TabIndex = 28;
            this.funcBtn5.Text = "tg";
            this.funcBtn5.UseVisualStyleBackColor = true;
            // 
            // funcBtn6
            // 
            this.funcBtn6.Location = new System.Drawing.Point(416, 248);
            this.funcBtn6.Name = "funcBtn6";
            this.funcBtn6.Size = new System.Drawing.Size(46, 23);
            this.funcBtn6.TabIndex = 29;
            this.funcBtn6.Text = "arctg";
            this.funcBtn6.UseVisualStyleBackColor = true;
            // 
            // constBtn1
            // 
            this.constBtn1.Location = new System.Drawing.Point(300, 53);
            this.constBtn1.Name = "constBtn1";
            this.constBtn1.Size = new System.Drawing.Size(46, 23);
            this.constBtn1.TabIndex = 30;
            this.constBtn1.Text = "PI";
            this.constBtn1.UseVisualStyleBackColor = true;
            // 
            // funcBtn7
            // 
            this.funcBtn7.Location = new System.Drawing.Point(468, 190);
            this.funcBtn7.Name = "funcBtn7";
            this.funcBtn7.Size = new System.Drawing.Size(46, 23);
            this.funcBtn7.TabIndex = 31;
            this.funcBtn7.Text = "exp";
            this.funcBtn7.UseVisualStyleBackColor = true;
            // 
            // constBtn2
            // 
            this.constBtn2.Location = new System.Drawing.Point(300, 82);
            this.constBtn2.Name = "constBtn2";
            this.constBtn2.Size = new System.Drawing.Size(46, 23);
            this.constBtn2.TabIndex = 32;
            this.constBtn2.Text = "E";
            this.constBtn2.UseVisualStyleBackColor = true;
            // 
            // numBtn11
            // 
            this.numBtn11.Location = new System.Drawing.Point(364, 140);
            this.numBtn11.Name = "numBtn11";
            this.numBtn11.Size = new System.Drawing.Size(46, 23);
            this.numBtn11.TabIndex = 33;
            this.numBtn11.Text = "(";
            this.numBtn11.UseVisualStyleBackColor = true;
            // 
            // numBtn12
            // 
            this.numBtn12.Location = new System.Drawing.Point(468, 140);
            this.numBtn12.Name = "numBtn12";
            this.numBtn12.Size = new System.Drawing.Size(46, 23);
            this.numBtn12.TabIndex = 34;
            this.numBtn12.Text = ")";
            this.numBtn12.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 414);
            this.Controls.Add(this.numBtn12);
            this.Controls.Add(this.numBtn11);
            this.Controls.Add(this.constBtn2);
            this.Controls.Add(this.funcBtn7);
            this.Controls.Add(this.constBtn1);
            this.Controls.Add(this.funcBtn6);
            this.Controls.Add(this.funcBtn5);
            this.Controls.Add(this.funcBtn4);
            this.Controls.Add(this.funcBtn3);
            this.Controls.Add(this.funcBtn2);
            this.Controls.Add(this.funcBtn1);
            this.Controls.Add(this.opBtn5);
            this.Controls.Add(this.opBtn4);
            this.Controls.Add(this.opBtn3);
            this.Controls.Add(this.opBtn2);
            this.Controls.Add(this.opBtn1);
            this.Controls.Add(this.numBtn10);
            this.Controls.Add(this.numBtn9);
            this.Controls.Add(this.numBtn8);
            this.Controls.Add(this.numBtn7);
            this.Controls.Add(this.numBtn6);
            this.Controls.Add(this.numBtn5);
            this.Controls.Add(this.numBtn4);
            this.Controls.Add(this.numBtn3);
            this.Controls.Add(this.numBtn2);
            this.Controls.Add(this.numBtn1);
            this.Controls.Add(label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressionTb);
            this.Name = "MainForm";
            this.Text = "Вычислятор";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox expressionTb;
        private Label label1;
        private Button solveBtn;
        private Label resultLbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button addVarBtn;
        private Button removeVarBtn;
        private Button numBtn1;
        private Button numBtn2;
        private Button numBtn3;
        private Button numBtn4;
        private Button numBtn5;
        private Button numBtn6;
        private Button numBtn7;
        private Button numBtn8;
        private Button numBtn9;
        private Button numBtn10;
        private Button opBtn1;
        private Button opBtn2;
        private Button opBtn3;
        private Button opBtn4;
        private Button opBtn5;
        private Button funcBtn1;
        private Button funcBtn2;
        private Button funcBtn3;
        private Button funcBtn4;
        private Button funcBtn5;
        private Button funcBtn6;
        private Button constBtn1;
        private Button funcBtn7;
        private Button constBtn2;
        private Button numBtn11;
        private Button numBtn12;
    }
}