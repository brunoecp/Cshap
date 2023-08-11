namespace fofo
{
    partial class Form1
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
            CalcTB = new Button();
            BomDiaLB = new Label();
            homemTB = new TextBox();
            mulherTB = new TextBox();
            label1 = new Label();
            criancaTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            CarvaoLB = new Label();
            CarneLB = new Label();
            SaladaLB = new Label();
            FarofaLB = new Label();
            CervejaLB = new Label();
            RefriLB = new Label();
            GeloLB = new Label();
            SuspendLayout();
            // 
            // CalcTB
            // 
            CalcTB.Location = new Point(69, 178);
            CalcTB.Name = "CalcTB";
            CalcTB.Size = new Size(75, 23);
            CalcTB.TabIndex = 0;
            CalcTB.Text = "Calcular";
            CalcTB.UseVisualStyleBackColor = true;
            CalcTB.Click += button1_Click;
            // 
            // BomDiaLB
            // 
            BomDiaLB.AutoSize = true;
            BomDiaLB.Location = new Point(14, 30);
            BomDiaLB.Name = "BomDiaLB";
            BomDiaLB.Size = new Size(49, 15);
            BomDiaLB.TabIndex = 1;
            BomDiaLB.Text = "homem";
            BomDiaLB.Click += BomDiaLB_Click;
            // 
            // homemTB
            // 
            homemTB.Location = new Point(69, 22);
            homemTB.Name = "homemTB";
            homemTB.PlaceholderText = "0";
            homemTB.Size = new Size(100, 23);
            homemTB.TabIndex = 2;
            homemTB.TextChanged += textBox1_TextChanged;
            // 
            // mulherTB
            // 
            mulherTB.Location = new Point(69, 66);
            mulherTB.Name = "mulherTB";
            mulherTB.PlaceholderText = "0";
            mulherTB.Size = new Size(100, 23);
            mulherTB.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 74);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "mulher";
            // 
            // criancaTB
            // 
            criancaTB.Location = new Point(69, 115);
            criancaTB.Name = "criancaTB";
            criancaTB.PlaceholderText = "0";
            criancaTB.Size = new Size(100, 23);
            criancaTB.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 123);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "criança";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 25);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Carvao";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 86);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Salada";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 123);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Farofa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 54);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "Carne";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 154);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 11;
            label7.Text = "Cerveja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 186);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 12;
            label8.Text = "Refri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(234, 215);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 13;
            label9.Text = "Gelo";
            label9.Click += label9_Click;
            // 
            // CarvaoLB
            // 
            CarvaoLB.AutoSize = true;
            CarvaoLB.Location = new Point(293, 25);
            CarvaoLB.Name = "CarvaoLB";
            CarvaoLB.Size = new Size(0, 15);
            CarvaoLB.TabIndex = 14;
            CarvaoLB.Click += label10_Click;
            // 
            // CarneLB
            // 
            CarneLB.AutoSize = true;
            CarneLB.Location = new Point(293, 54);
            CarneLB.Name = "CarneLB";
            CarneLB.Size = new Size(0, 15);
            CarneLB.TabIndex = 15;
            // 
            // SaladaLB
            // 
            SaladaLB.AutoSize = true;
            SaladaLB.Location = new Point(293, 86);
            SaladaLB.Name = "SaladaLB";
            SaladaLB.Size = new Size(0, 15);
            SaladaLB.TabIndex = 16;
            // 
            // FarofaLB
            // 
            FarofaLB.AutoSize = true;
            FarofaLB.Location = new Point(293, 123);
            FarofaLB.Name = "FarofaLB";
            FarofaLB.Size = new Size(0, 15);
            FarofaLB.TabIndex = 17;
            // 
            // CervejaLB
            // 
            CervejaLB.AutoSize = true;
            CervejaLB.Location = new Point(293, 154);
            CervejaLB.Name = "CervejaLB";
            CervejaLB.Size = new Size(0, 15);
            CervejaLB.TabIndex = 18;
            // 
            // RefriLB
            // 
            RefriLB.AutoSize = true;
            RefriLB.Location = new Point(293, 186);
            RefriLB.Name = "RefriLB";
            RefriLB.Size = new Size(0, 15);
            RefriLB.TabIndex = 19;
            // 
            // GeloLB
            // 
            GeloLB.AutoSize = true;
            GeloLB.Location = new Point(293, 215);
            GeloLB.Name = "GeloLB";
            GeloLB.Size = new Size(0, 15);
            GeloLB.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(420, 249);
            Controls.Add(GeloLB);
            Controls.Add(RefriLB);
            Controls.Add(CervejaLB);
            Controls.Add(FarofaLB);
            Controls.Add(SaladaLB);
            Controls.Add(CarneLB);
            Controls.Add(CarvaoLB);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(criancaTB);
            Controls.Add(label2);
            Controls.Add(mulherTB);
            Controls.Add(label1);
            Controls.Add(homemTB);
            Controls.Add(BomDiaLB);
            Controls.Add(CalcTB);
            Name = "Form1";
            Text = "CalcChuras";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalcTB;
        private Label BomDiaLB;
        private TextBox homemTB;
        private TextBox mulherTB;
        private Label label1;
        private TextBox criancaTB;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label CarvaoLB;
        private Label CarneLB;
        private Label SaladaLB;
        private Label FarofaLB;
        private Label CervejaLB;
        private Label RefriLB;
        private Label GeloLB;
    }
}