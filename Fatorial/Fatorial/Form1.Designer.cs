namespace Fatorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.fatorialLB = new System.Windows.Forms.Label();
            this.calcBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digte o numero na qual você quer saber o fatorial:";
            // 
            // numeroTB
            // 
            this.numeroTB.Location = new System.Drawing.Point(78, 45);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(100, 20);
            this.numeroTB.TabIndex = 1;
            this.numeroTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroTB.TextChanged += new System.EventHandler(this.numeroTB_TextChanged);
            // 
            // fatorialLB
            // 
            this.fatorialLB.AutoSize = true;
            this.fatorialLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatorialLB.Location = new System.Drawing.Point(44, 121);
            this.fatorialLB.Name = "fatorialLB";
            this.fatorialLB.Size = new System.Drawing.Size(0, 29);
            this.fatorialLB.TabIndex = 2;
            // 
            // calcBT
            // 
            this.calcBT.Location = new System.Drawing.Point(94, 84);
            this.calcBT.Name = "calcBT";
            this.calcBT.Size = new System.Drawing.Size(75, 23);
            this.calcBT.TabIndex = 3;
            this.calcBT.Text = "Calcular";
            this.calcBT.UseVisualStyleBackColor = true;
            this.calcBT.Click += new System.EventHandler(this.calcBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 175);
            this.Controls.Add(this.calcBT);
            this.Controls.Add(this.fatorialLB);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fatorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroTB;
        private System.Windows.Forms.Label fatorialLB;
        private System.Windows.Forms.Button calcBT;
    }
}

