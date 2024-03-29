﻿namespace StringEvaluatorDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.expressionTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
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
            this.eraseBtn = new System.Windows.Forms.Button();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.countNud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshChartBtn = new System.Windows.Forms.Button();
            this.argumentMaxNud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.argumentMinNud = new System.Windows.Forms.NumericUpDown();
            this.mainChart = new OxyPlot.WindowsForms.PlotView();
            this.label4 = new System.Windows.Forms.Label();
            this.argumentNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentMaxNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentMinNud)).BeginInit();
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
            this.numBtn1.Location = new System.Drawing.Point(71, 35);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(46, 23);
            this.numBtn1.TabIndex = 9;
            this.numBtn1.Text = "1";
            this.numBtn1.UseVisualStyleBackColor = true;
            this.numBtn1.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn2
            // 
            this.numBtn2.Location = new System.Drawing.Point(123, 35);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(46, 23);
            this.numBtn2.TabIndex = 10;
            this.numBtn2.Text = "2";
            this.numBtn2.UseVisualStyleBackColor = true;
            this.numBtn2.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn3
            // 
            this.numBtn3.Location = new System.Drawing.Point(175, 35);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(46, 23);
            this.numBtn3.TabIndex = 11;
            this.numBtn3.Text = "3";
            this.numBtn3.UseVisualStyleBackColor = true;
            this.numBtn3.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn4
            // 
            this.numBtn4.Location = new System.Drawing.Point(71, 64);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(46, 23);
            this.numBtn4.TabIndex = 12;
            this.numBtn4.Text = "4";
            this.numBtn4.UseVisualStyleBackColor = true;
            this.numBtn4.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn5
            // 
            this.numBtn5.Location = new System.Drawing.Point(123, 64);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(46, 23);
            this.numBtn5.TabIndex = 13;
            this.numBtn5.Text = "5";
            this.numBtn5.UseVisualStyleBackColor = true;
            this.numBtn5.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn6
            // 
            this.numBtn6.Location = new System.Drawing.Point(175, 64);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(46, 23);
            this.numBtn6.TabIndex = 14;
            this.numBtn6.Text = "6";
            this.numBtn6.UseVisualStyleBackColor = true;
            this.numBtn6.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn7
            // 
            this.numBtn7.Location = new System.Drawing.Point(71, 93);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(46, 23);
            this.numBtn7.TabIndex = 15;
            this.numBtn7.Text = "7";
            this.numBtn7.UseVisualStyleBackColor = true;
            this.numBtn7.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn8
            // 
            this.numBtn8.Location = new System.Drawing.Point(123, 93);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(46, 23);
            this.numBtn8.TabIndex = 16;
            this.numBtn8.Text = "8";
            this.numBtn8.UseVisualStyleBackColor = true;
            this.numBtn8.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn9
            // 
            this.numBtn9.Location = new System.Drawing.Point(175, 93);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(46, 23);
            this.numBtn9.TabIndex = 17;
            this.numBtn9.Text = "9";
            this.numBtn9.UseVisualStyleBackColor = true;
            this.numBtn9.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn10
            // 
            this.numBtn10.Location = new System.Drawing.Point(123, 122);
            this.numBtn10.Name = "numBtn10";
            this.numBtn10.Size = new System.Drawing.Size(46, 23);
            this.numBtn10.TabIndex = 18;
            this.numBtn10.Text = "0";
            this.numBtn10.UseVisualStyleBackColor = true;
            this.numBtn10.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // opBtn1
            // 
            this.opBtn1.Location = new System.Drawing.Point(245, 35);
            this.opBtn1.Name = "opBtn1";
            this.opBtn1.Size = new System.Drawing.Size(46, 23);
            this.opBtn1.TabIndex = 19;
            this.opBtn1.Text = "+";
            this.opBtn1.UseVisualStyleBackColor = true;
            this.opBtn1.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // opBtn2
            // 
            this.opBtn2.Location = new System.Drawing.Point(245, 64);
            this.opBtn2.Name = "opBtn2";
            this.opBtn2.Size = new System.Drawing.Size(46, 23);
            this.opBtn2.TabIndex = 20;
            this.opBtn2.Text = "-";
            this.opBtn2.UseVisualStyleBackColor = true;
            this.opBtn2.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // opBtn3
            // 
            this.opBtn3.Location = new System.Drawing.Point(245, 93);
            this.opBtn3.Name = "opBtn3";
            this.opBtn3.Size = new System.Drawing.Size(46, 23);
            this.opBtn3.TabIndex = 21;
            this.opBtn3.Text = "*";
            this.opBtn3.UseVisualStyleBackColor = true;
            this.opBtn3.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // opBtn4
            // 
            this.opBtn4.Location = new System.Drawing.Point(245, 122);
            this.opBtn4.Name = "opBtn4";
            this.opBtn4.Size = new System.Drawing.Size(46, 23);
            this.opBtn4.TabIndex = 22;
            this.opBtn4.Text = "/";
            this.opBtn4.UseVisualStyleBackColor = true;
            this.opBtn4.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // opBtn5
            // 
            this.opBtn5.Location = new System.Drawing.Point(245, 151);
            this.opBtn5.Name = "opBtn5";
            this.opBtn5.Size = new System.Drawing.Size(46, 23);
            this.opBtn5.TabIndex = 23;
            this.opBtn5.Text = "^";
            this.opBtn5.UseVisualStyleBackColor = true;
            this.opBtn5.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // funcBtn1
            // 
            this.funcBtn1.Location = new System.Drawing.Point(71, 180);
            this.funcBtn1.Name = "funcBtn1";
            this.funcBtn1.Size = new System.Drawing.Size(46, 23);
            this.funcBtn1.TabIndex = 24;
            this.funcBtn1.Text = "sqrt";
            this.funcBtn1.UseVisualStyleBackColor = true;
            this.funcBtn1.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // funcBtn2
            // 
            this.funcBtn2.Location = new System.Drawing.Point(123, 180);
            this.funcBtn2.Name = "funcBtn2";
            this.funcBtn2.Size = new System.Drawing.Size(46, 23);
            this.funcBtn2.TabIndex = 25;
            this.funcBtn2.Text = "ln";
            this.funcBtn2.UseVisualStyleBackColor = true;
            this.funcBtn2.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // funcBtn3
            // 
            this.funcBtn3.Location = new System.Drawing.Point(71, 209);
            this.funcBtn3.Name = "funcBtn3";
            this.funcBtn3.Size = new System.Drawing.Size(46, 23);
            this.funcBtn3.TabIndex = 26;
            this.funcBtn3.Text = "sin";
            this.funcBtn3.UseVisualStyleBackColor = true;
            this.funcBtn3.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // funcBtn4
            // 
            this.funcBtn4.Location = new System.Drawing.Point(123, 209);
            this.funcBtn4.Name = "funcBtn4";
            this.funcBtn4.Size = new System.Drawing.Size(46, 23);
            this.funcBtn4.TabIndex = 27;
            this.funcBtn4.Text = "cos";
            this.funcBtn4.UseVisualStyleBackColor = true;
            this.funcBtn4.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // funcBtn5
            // 
            this.funcBtn5.Location = new System.Drawing.Point(175, 209);
            this.funcBtn5.Name = "funcBtn5";
            this.funcBtn5.Size = new System.Drawing.Size(46, 23);
            this.funcBtn5.TabIndex = 28;
            this.funcBtn5.Text = "tg";
            this.funcBtn5.UseVisualStyleBackColor = true;
            this.funcBtn5.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // funcBtn6
            // 
            this.funcBtn6.Location = new System.Drawing.Point(123, 238);
            this.funcBtn6.Name = "funcBtn6";
            this.funcBtn6.Size = new System.Drawing.Size(46, 23);
            this.funcBtn6.TabIndex = 29;
            this.funcBtn6.Text = "arctg";
            this.funcBtn6.UseVisualStyleBackColor = true;
            this.funcBtn6.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // constBtn1
            // 
            this.constBtn1.Location = new System.Drawing.Point(6, 35);
            this.constBtn1.Name = "constBtn1";
            this.constBtn1.Size = new System.Drawing.Size(46, 23);
            this.constBtn1.TabIndex = 30;
            this.constBtn1.Text = "PI";
            this.constBtn1.UseVisualStyleBackColor = true;
            this.constBtn1.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // funcBtn7
            // 
            this.funcBtn7.Location = new System.Drawing.Point(175, 180);
            this.funcBtn7.Name = "funcBtn7";
            this.funcBtn7.Size = new System.Drawing.Size(46, 23);
            this.funcBtn7.TabIndex = 31;
            this.funcBtn7.Text = "exp";
            this.funcBtn7.UseVisualStyleBackColor = true;
            this.funcBtn7.Click += new System.EventHandler(this.FuncBtnClicked);
            // 
            // constBtn2
            // 
            this.constBtn2.Location = new System.Drawing.Point(6, 64);
            this.constBtn2.Name = "constBtn2";
            this.constBtn2.Size = new System.Drawing.Size(46, 23);
            this.constBtn2.TabIndex = 32;
            this.constBtn2.Text = "e";
            this.constBtn2.UseVisualStyleBackColor = true;
            this.constBtn2.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn11
            // 
            this.numBtn11.Location = new System.Drawing.Point(71, 122);
            this.numBtn11.Name = "numBtn11";
            this.numBtn11.Size = new System.Drawing.Size(46, 23);
            this.numBtn11.TabIndex = 33;
            this.numBtn11.Text = "(";
            this.numBtn11.UseVisualStyleBackColor = true;
            this.numBtn11.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // numBtn12
            // 
            this.numBtn12.Location = new System.Drawing.Point(175, 122);
            this.numBtn12.Name = "numBtn12";
            this.numBtn12.Size = new System.Drawing.Size(46, 23);
            this.numBtn12.TabIndex = 34;
            this.numBtn12.Text = ")";
            this.numBtn12.UseVisualStyleBackColor = true;
            this.numBtn12.Click += new System.EventHandler(this.NumBtnClicked);
            // 
            // eraseBtn
            // 
            this.eraseBtn.Location = new System.Drawing.Point(310, 35);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(46, 23);
            this.eraseBtn.TabIndex = 35;
            this.eraseBtn.Text = "С";
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.Location = new System.Drawing.Point(310, 6);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(46, 23);
            this.backspaceBtn.TabIndex = 36;
            this.backspaceBtn.Text = "<-";
            this.backspaceBtn.UseVisualStyleBackColor = true;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(286, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 354);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.backspaceBtn);
            this.tabPage1.Controls.Add(this.constBtn1);
            this.tabPage1.Controls.Add(this.funcBtn6);
            this.tabPage1.Controls.Add(this.eraseBtn);
            this.tabPage1.Controls.Add(this.funcBtn4);
            this.tabPage1.Controls.Add(this.funcBtn3);
            this.tabPage1.Controls.Add(this.constBtn2);
            this.tabPage1.Controls.Add(this.numBtn11);
            this.tabPage1.Controls.Add(this.numBtn12);
            this.tabPage1.Controls.Add(this.numBtn1);
            this.tabPage1.Controls.Add(this.numBtn4);
            this.tabPage1.Controls.Add(this.numBtn6);
            this.tabPage1.Controls.Add(this.numBtn2);
            this.tabPage1.Controls.Add(this.numBtn3);
            this.tabPage1.Controls.Add(this.numBtn9);
            this.tabPage1.Controls.Add(this.numBtn5);
            this.tabPage1.Controls.Add(this.funcBtn5);
            this.tabPage1.Controls.Add(this.numBtn8);
            this.tabPage1.Controls.Add(this.funcBtn2);
            this.tabPage1.Controls.Add(this.numBtn7);
            this.tabPage1.Controls.Add(this.numBtn10);
            this.tabPage1.Controls.Add(this.funcBtn1);
            this.tabPage1.Controls.Add(this.funcBtn7);
            this.tabPage1.Controls.Add(this.opBtn1);
            this.tabPage1.Controls.Add(this.opBtn2);
            this.tabPage1.Controls.Add(this.opBtn3);
            this.tabPage1.Controls.Add(this.opBtn4);
            this.tabPage1.Controls.Add(this.opBtn5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вычисление";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.countNud);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.refreshChartBtn);
            this.tabPage2.Controls.Add(this.argumentMaxNud);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.argumentMinNud);
            this.tabPage2.Controls.Add(this.mainChart);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.argumentNameTb);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График функции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // countNud
            // 
            this.countNud.Location = new System.Drawing.Point(286, 7);
            this.countNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countNud.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countNud.Name = "countNud";
            this.countNud.Size = new System.Drawing.Size(77, 23);
            this.countNud.TabIndex = 9;
            this.countNud.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вычислений:";
            // 
            // refreshChartBtn
            // 
            this.refreshChartBtn.BackgroundImage = global::StringEvaluatorDesktop.Properties.Resources.kisspng_computer_icons_arrow_symbol_configuration_management_icon_5b55a51783aee9_1471779115323394795394;
            this.refreshChartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshChartBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshChartBtn.Location = new System.Drawing.Point(313, 33);
            this.refreshChartBtn.Name = "refreshChartBtn";
            this.refreshChartBtn.Size = new System.Drawing.Size(50, 25);
            this.refreshChartBtn.TabIndex = 7;
            this.refreshChartBtn.UseVisualStyleBackColor = true;
            this.refreshChartBtn.Click += new System.EventHandler(this.refreshChartBtn_Click);
            // 
            // argumentMaxNud
            // 
            this.argumentMaxNud.DecimalPlaces = 5;
            this.argumentMaxNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.argumentMaxNud.Location = new System.Drawing.Point(213, 35);
            this.argumentMaxNud.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.argumentMaxNud.Minimum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            -2147483648});
            this.argumentMaxNud.Name = "argumentMaxNud";
            this.argumentMaxNud.Size = new System.Drawing.Size(94, 23);
            this.argumentMaxNud.TabIndex = 6;
            this.argumentMaxNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "до";
            // 
            // argumentMinNud
            // 
            this.argumentMinNud.DecimalPlaces = 5;
            this.argumentMinNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.argumentMinNud.Location = new System.Drawing.Point(87, 35);
            this.argumentMinNud.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.argumentMinNud.Minimum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            -2147483648});
            this.argumentMinNud.Name = "argumentMinNud";
            this.argumentMinNud.Size = new System.Drawing.Size(94, 23);
            this.argumentMinNud.TabIndex = 4;
            this.argumentMinNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // mainChart
            // 
            this.mainChart.Location = new System.Drawing.Point(6, 69);
            this.mainChart.Name = "mainChart";
            this.mainChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.mainChart.Size = new System.Drawing.Size(362, 251);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "plotView1";
            this.mainChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.mainChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.mainChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Значение от";
            // 
            // argumentNameTb
            // 
            this.argumentNameTb.Location = new System.Drawing.Point(158, 6);
            this.argumentNameTb.Name = "argumentNameTb";
            this.argumentNameTb.Size = new System.Drawing.Size(36, 23);
            this.argumentNameTb.TabIndex = 2;
            this.argumentNameTb.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя аргумента функции:";
            // 
            // resultLbl
            // 
            this.resultLbl.BackColor = System.Drawing.SystemColors.Control;
            this.resultLbl.Location = new System.Drawing.Point(522, 6);
            this.resultLbl.MaxLength = 17;
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.ReadOnly = true;
            this.resultLbl.Size = new System.Drawing.Size(143, 23);
            this.resultLbl.TabIndex = 38;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 414);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expressionTb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Вычисление математических выражений";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentMaxNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.argumentMinNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox expressionTb;
        private Label label1;
        private Button solveBtn;
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
        private Button eraseBtn;
        private Button backspaceBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox resultLbl;
        private NumericUpDown argumentMaxNud;
        private Label label5;
        private NumericUpDown argumentMinNud;
        private OxyPlot.WindowsForms.PlotView mainChart;
        private Label label4;
        private TextBox argumentNameTb;
        private Label label3;
        private Button refreshChartBtn;
        private NumericUpDown countNud;
        private Label label6;
    }
}