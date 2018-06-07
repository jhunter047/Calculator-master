namespace Calculator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.TimesBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.SubtractionBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EqualsBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.BackSpaceBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.MaximizeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 28);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(154, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(28, 28);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Black;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.ForeColor = System.Drawing.Color.White;
            this.MaximizeButton.Location = new System.Drawing.Point(182, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(28, 28);
            this.MaximizeButton.TabIndex = 7;
            this.MaximizeButton.Text = "☐";
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            this.MaximizeButton.MouseEnter += new System.EventHandler(this.MaximizeButton_MouseEnter);
            this.MaximizeButton.MouseLeave += new System.EventHandler(this.MaximizeButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(210, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 28);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // SixBtn
            // 
            this.SixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SixBtn.FlatAppearance.BorderSize = 0;
            this.SixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixBtn.ForeColor = System.Drawing.Color.White;
            this.SixBtn.Location = new System.Drawing.Point(118, 268);
            this.SixBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(60, 60);
            this.SixBtn.TabIndex = 11;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            this.SixBtn.MouseEnter += new System.EventHandler(this.SixBtn_MouseEnter);
            this.SixBtn.MouseLeave += new System.EventHandler(this.SixBtn_MouseLeave);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveBtn.FlatAppearance.BorderSize = 0;
            this.FiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveBtn.ForeColor = System.Drawing.Color.White;
            this.FiveBtn.Location = new System.Drawing.Point(58, 268);
            this.FiveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(60, 60);
            this.FiveBtn.TabIndex = 10;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            this.FiveBtn.MouseEnter += new System.EventHandler(this.FiveBtn_MouseEnter);
            this.FiveBtn.MouseLeave += new System.EventHandler(this.FiveBtn_MouseLeave);
            // 
            // TimesBtn
            // 
            this.TimesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimesBtn.FlatAppearance.BorderSize = 0;
            this.TimesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimesBtn.ForeColor = System.Drawing.Color.White;
            this.TimesBtn.Location = new System.Drawing.Point(178, 208);
            this.TimesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.TimesBtn.Name = "TimesBtn";
            this.TimesBtn.Size = new System.Drawing.Size(60, 60);
            this.TimesBtn.TabIndex = 12;
            this.TimesBtn.Text = "*";
            this.TimesBtn.UseVisualStyleBackColor = true;
            this.TimesBtn.Click += new System.EventHandler(this.TimesBtn_Click);
            this.TimesBtn.MouseEnter += new System.EventHandler(this.TimesBtn_MouseEnter);
            this.TimesBtn.MouseLeave += new System.EventHandler(this.TimesBtn_MouseLeave);
            // 
            // FourBtn
            // 
            this.FourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FourBtn.FlatAppearance.BorderSize = 0;
            this.FourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourBtn.ForeColor = System.Drawing.Color.White;
            this.FourBtn.Location = new System.Drawing.Point(-2, 268);
            this.FourBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(60, 60);
            this.FourBtn.TabIndex = 9;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            this.FourBtn.MouseEnter += new System.EventHandler(this.FourBtn_MouseEnter);
            this.FourBtn.MouseLeave += new System.EventHandler(this.FourBtn_MouseLeave);
            // 
            // OneBtn
            // 
            this.OneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OneBtn.FlatAppearance.BorderSize = 0;
            this.OneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneBtn.ForeColor = System.Drawing.Color.White;
            this.OneBtn.Location = new System.Drawing.Point(-2, 328);
            this.OneBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(60, 60);
            this.OneBtn.TabIndex = 13;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            this.OneBtn.MouseEnter += new System.EventHandler(this.OneBtn_MouseEnter);
            this.OneBtn.MouseLeave += new System.EventHandler(this.OneBtn_MouseLeave);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractionBtn.FlatAppearance.BorderSize = 0;
            this.SubtractionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractionBtn.ForeColor = System.Drawing.Color.White;
            this.SubtractionBtn.Location = new System.Drawing.Point(178, 268);
            this.SubtractionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(60, 60);
            this.SubtractionBtn.TabIndex = 8;
            this.SubtractionBtn.Text = "-";
            this.SubtractionBtn.UseVisualStyleBackColor = true;
            this.SubtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            this.SubtractionBtn.MouseEnter += new System.EventHandler(this.SubtractionBtn_MouseEnter);
            this.SubtractionBtn.MouseLeave += new System.EventHandler(this.SubtractionBtn_MouseLeave);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoBtn.FlatAppearance.BorderSize = 0;
            this.TwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoBtn.ForeColor = System.Drawing.Color.White;
            this.TwoBtn.Location = new System.Drawing.Point(58, 328);
            this.TwoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(60, 60);
            this.TwoBtn.TabIndex = 14;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            this.TwoBtn.MouseEnter += new System.EventHandler(this.TwoBtn_MouseEnter);
            this.TwoBtn.MouseLeave += new System.EventHandler(this.TwoBtn_MouseLeave);
            // 
            // NineBtn
            // 
            this.NineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NineBtn.FlatAppearance.BorderSize = 0;
            this.NineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineBtn.ForeColor = System.Drawing.Color.White;
            this.NineBtn.Location = new System.Drawing.Point(120, 208);
            this.NineBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(60, 60);
            this.NineBtn.TabIndex = 7;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            this.NineBtn.MouseEnter += new System.EventHandler(this.NineBtn_MouseEnter);
            this.NineBtn.MouseLeave += new System.EventHandler(this.NineBtn_MouseLeave);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeBtn.FlatAppearance.BorderSize = 0;
            this.ThreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeBtn.ForeColor = System.Drawing.Color.White;
            this.ThreeBtn.Location = new System.Drawing.Point(118, 328);
            this.ThreeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(60, 60);
            this.ThreeBtn.TabIndex = 15;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            this.ThreeBtn.MouseEnter += new System.EventHandler(this.ThreeBtn_MouseEnter);
            this.ThreeBtn.MouseLeave += new System.EventHandler(this.ThreeBtn_MouseLeave);
            // 
            // EightBtn
            // 
            this.EightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EightBtn.FlatAppearance.BorderSize = 0;
            this.EightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightBtn.ForeColor = System.Drawing.Color.White;
            this.EightBtn.Location = new System.Drawing.Point(60, 208);
            this.EightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(60, 60);
            this.EightBtn.TabIndex = 6;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            this.EightBtn.MouseEnter += new System.EventHandler(this.EightBtn_MouseEnter);
            this.EightBtn.MouseLeave += new System.EventHandler(this.EightBtn_MouseLeave);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionBtn.FlatAppearance.BorderSize = 0;
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionBtn.ForeColor = System.Drawing.Color.White;
            this.DivisionBtn.Location = new System.Drawing.Point(180, 148);
            this.DivisionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(60, 60);
            this.DivisionBtn.TabIndex = 16;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            this.DivisionBtn.MouseEnter += new System.EventHandler(this.DivisionBtn_MouseEnter);
            this.DivisionBtn.MouseLeave += new System.EventHandler(this.DivisionBtn_MouseLeave);
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionBtn.FlatAppearance.BorderSize = 0;
            this.AdditionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionBtn.ForeColor = System.Drawing.Color.White;
            this.AdditionBtn.Location = new System.Drawing.Point(178, 328);
            this.AdditionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(60, 60);
            this.AdditionBtn.TabIndex = 4;
            this.AdditionBtn.Text = "+";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            this.AdditionBtn.MouseEnter += new System.EventHandler(this.AdditionBtn_MouseEnter);
            this.AdditionBtn.MouseLeave += new System.EventHandler(this.AdditionBtn_MouseLeave);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroBtn.FlatAppearance.BorderSize = 0;
            this.ZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroBtn.ForeColor = System.Drawing.Color.White;
            this.ZeroBtn.Location = new System.Drawing.Point(-2, 388);
            this.ZeroBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(60, 60);
            this.ZeroBtn.TabIndex = 17;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            this.ZeroBtn.MouseEnter += new System.EventHandler(this.ZeroBtn_MouseEnter);
            this.ZeroBtn.MouseLeave += new System.EventHandler(this.ZeroBtn_MouseLeave);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(118, 148);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(60, 60);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            this.ClearBtn.MouseEnter += new System.EventHandler(this.ClearBtn_MouseEnter);
            this.ClearBtn.MouseLeave += new System.EventHandler(this.ClearBtn_MouseLeave);
            // 
            // DotBtn
            // 
            this.DotBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DotBtn.FlatAppearance.BorderSize = 0;
            this.DotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotBtn.ForeColor = System.Drawing.Color.White;
            this.DotBtn.Location = new System.Drawing.Point(58, 388);
            this.DotBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(60, 60);
            this.DotBtn.TabIndex = 18;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = true;
            this.DotBtn.Click += new System.EventHandler(this.DotBtn_Click);
            this.DotBtn.MouseEnter += new System.EventHandler(this.DotBtn_MouseEnter);
            this.DotBtn.MouseLeave += new System.EventHandler(this.DotBtn_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 62);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EqualsBtn
            // 
            this.EqualsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualsBtn.FlatAppearance.BorderSize = 0;
            this.EqualsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsBtn.ForeColor = System.Drawing.Color.White;
            this.EqualsBtn.Location = new System.Drawing.Point(118, 388);
            this.EqualsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EqualsBtn.Name = "EqualsBtn";
            this.EqualsBtn.Size = new System.Drawing.Size(120, 60);
            this.EqualsBtn.TabIndex = 19;
            this.EqualsBtn.Text = "=";
            this.EqualsBtn.UseVisualStyleBackColor = true;
            this.EqualsBtn.Click += new System.EventHandler(this.EqualsBtn_Click);
            this.EqualsBtn.MouseEnter += new System.EventHandler(this.EqualsBtn_MouseEnter);
            this.EqualsBtn.MouseLeave += new System.EventHandler(this.EqualsBtn_MouseLeave);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenBtn.FlatAppearance.BorderSize = 0;
            this.SevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenBtn.ForeColor = System.Drawing.Color.White;
            this.SevenBtn.Location = new System.Drawing.Point(0, 208);
            this.SevenBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(60, 60);
            this.SevenBtn.TabIndex = 5;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            this.SevenBtn.MouseEnter += new System.EventHandler(this.SevenBtn_MouseEnter);
            this.SevenBtn.MouseLeave += new System.EventHandler(this.SevenBtn_MouseLeave);
            // 
            // BackSpaceBtn
            // 
            this.BackSpaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackSpaceBtn.FlatAppearance.BorderSize = 0;
            this.BackSpaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSpaceBtn.ForeColor = System.Drawing.Color.White;
            this.BackSpaceBtn.Location = new System.Drawing.Point(58, 148);
            this.BackSpaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BackSpaceBtn.Name = "BackSpaceBtn";
            this.BackSpaceBtn.Size = new System.Drawing.Size(60, 60);
            this.BackSpaceBtn.TabIndex = 2;
            this.BackSpaceBtn.Text = "<------";
            this.BackSpaceBtn.UseVisualStyleBackColor = true;
            this.BackSpaceBtn.Click += new System.EventHandler(this.BackSpaceBtn_Click);
            this.BackSpaceBtn.MouseEnter += new System.EventHandler(this.BackSpaceBtn_MouseEnter);
            this.BackSpaceBtn.MouseLeave += new System.EventHandler(this.BackSpaceBtn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BackSpaceBtn);
            this.panel2.Controls.Add(this.SevenBtn);
            this.panel2.Controls.Add(this.EqualsBtn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.DotBtn);
            this.panel2.Controls.Add(this.ClearBtn);
            this.panel2.Controls.Add(this.ZeroBtn);
            this.panel2.Controls.Add(this.AdditionBtn);
            this.panel2.Controls.Add(this.DivisionBtn);
            this.panel2.Controls.Add(this.EightBtn);
            this.panel2.Controls.Add(this.ThreeBtn);
            this.panel2.Controls.Add(this.NineBtn);
            this.panel2.Controls.Add(this.TwoBtn);
            this.panel2.Controls.Add(this.SubtractionBtn);
            this.panel2.Controls.Add(this.OneBtn);
            this.panel2.Controls.Add(this.FourBtn);
            this.panel2.Controls.Add(this.TimesBtn);
            this.panel2.Controls.Add(this.FiveBtn);
            this.panel2.Controls.Add(this.SixBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 450);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(238, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button TimesBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button SubtractionBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EqualsBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button BackSpaceBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

