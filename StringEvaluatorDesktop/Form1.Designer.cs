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
            this.expressionTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xValueTb = new System.Windows.Forms.TextBox();
            this.yValueTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.solveBtn.Location = new System.Drawing.Point(92, 99);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(100, 23);
            this.solveBtn.TabIndex = 2;
            this.solveBtn.Text = "Решить!";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLbl.Location = new System.Drawing.Point(309, 44);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(12, 15);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "X = ";
            // 
            // xValueTb
            // 
            this.xValueTb.Location = new System.Drawing.Point(92, 41);
            this.xValueTb.Name = "xValueTb";
            this.xValueTb.Size = new System.Drawing.Size(100, 23);
            this.xValueTb.TabIndex = 6;
            // 
            // yValueTb
            // 
            this.yValueTb.Location = new System.Drawing.Point(92, 70);
            this.yValueTb.Name = "yValueTb";
            this.yValueTb.Size = new System.Drawing.Size(100, 23);
            this.yValueTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yValueTb);
            this.Controls.Add(this.xValueTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label resultLbl;
        private Label label3;
        private TextBox xValueTb;
        private TextBox yValueTb;
        private Label label4;
    }
}