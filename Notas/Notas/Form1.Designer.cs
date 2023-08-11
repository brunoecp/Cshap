namespace Notas
{
    partial class Form1
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
            this.nota1TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nota2TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nota3TB = new System.Windows.Forms.TextBox();
            this.CalcBT = new System.Windows.Forms.Button();
            this.limparBT = new System.Windows.Forms.Button();
            this.notaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nota1TB
            // 
            this.nota1TB.Location = new System.Drawing.Point(35, 69);
            this.nota1TB.Name = "nota1TB";
            this.nota1TB.Size = new System.Drawing.Size(100, 20);
            this.nota1TB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota 2";
            // 
            // nota2TB
            // 
            this.nota2TB.Location = new System.Drawing.Point(194, 69);
            this.nota2TB.Name = "nota2TB";
            this.nota2TB.Size = new System.Drawing.Size(100, 20);
            this.nota2TB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3";
            // 
            // nota3TB
            // 
            this.nota3TB.Location = new System.Drawing.Point(346, 69);
            this.nota3TB.Name = "nota3TB";
            this.nota3TB.Size = new System.Drawing.Size(100, 20);
            this.nota3TB.TabIndex = 4;
            // 
            // CalcBT
            // 
            this.CalcBT.Location = new System.Drawing.Point(115, 161);
            this.CalcBT.Name = "CalcBT";
            this.CalcBT.Size = new System.Drawing.Size(118, 23);
            this.CalcBT.TabIndex = 6;
            this.CalcBT.Text = "Calcular media";
            this.CalcBT.UseVisualStyleBackColor = true;
            this.CalcBT.Click += new System.EventHandler(this.CalcBT_Click);
            // 
            // limparBT
            // 
            this.limparBT.Location = new System.Drawing.Point(267, 161);
            this.limparBT.Name = "limparBT";
            this.limparBT.Size = new System.Drawing.Size(118, 23);
            this.limparBT.TabIndex = 7;
            this.limparBT.Text = "Limpar";
            this.limparBT.UseVisualStyleBackColor = true;
            // 
            // notaLB
            // 
            this.notaLB.AutoSize = true;
            this.notaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaLB.Location = new System.Drawing.Point(201, 230);
            this.notaLB.Name = "notaLB";
            this.notaLB.Size = new System.Drawing.Size(0, 51);
            this.notaLB.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.notaLB);
            this.Controls.Add(this.limparBT);
            this.Controls.Add(this.CalcBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nota3TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nota2TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nota1TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nota1TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nota2TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nota3TB;
        private System.Windows.Forms.Button CalcBT;
        private System.Windows.Forms.Button limparBT;
        private System.Windows.Forms.Label notaLB;
    }
}

