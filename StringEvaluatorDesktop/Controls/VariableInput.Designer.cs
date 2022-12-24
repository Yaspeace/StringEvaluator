namespace StringEvaluatorDesktop.Controls
{
    partial class VariableInput
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.valueNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueNud)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(3, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(54, 23);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valueNud
            // 
            this.valueNud.DecimalPlaces = 5;
            this.valueNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.valueNud.Location = new System.Drawing.Point(82, 3);
            this.valueNud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.valueNud.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.valueNud.Name = "valueNud";
            this.valueNud.Size = new System.Drawing.Size(120, 23);
            this.valueNud.TabIndex = 1;
            this.valueNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // VariableInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueNud);
            this.Controls.Add(this.nameTextBox);
            this.Name = "VariableInput";
            this.Size = new System.Drawing.Size(205, 31);
            ((System.ComponentModel.ISupportInitialize)(this.valueNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private NumericUpDown valueNud;
        private Label label1;
    }
}
