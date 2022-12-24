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
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(92, 35);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(92, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 354);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // addVarBtn
            // 
            this.addVarBtn.Location = new System.Drawing.Point(366, 53);
            this.addVarBtn.Name = "addVarBtn";
            this.addVarBtn.Size = new System.Drawing.Size(98, 23);
            this.addVarBtn.TabIndex = 9;
            this.addVarBtn.Text = "Добавить";
            this.addVarBtn.UseVisualStyleBackColor = true;
            this.addVarBtn.Click += new System.EventHandler(this.addVarBtn_Click);
            // 
            // removeVarBtn
            // 
            this.removeVarBtn.Location = new System.Drawing.Point(366, 82);
            this.removeVarBtn.Name = "removeVarBtn";
            this.removeVarBtn.Size = new System.Drawing.Size(98, 23);
            this.removeVarBtn.TabIndex = 10;
            this.removeVarBtn.Text = "Убрать";
            this.removeVarBtn.UseVisualStyleBackColor = true;
            this.removeVarBtn.Click += new System.EventHandler(this.removeVarBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 414);
            this.Controls.Add(this.removeVarBtn);
            this.Controls.Add(this.addVarBtn);
            this.Controls.Add(label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressionTb);
            this.Name = "MainForm";
            this.Text = "Вычислятор";
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
    }
}