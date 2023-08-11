using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Double CalcMenor(List<Double> notas)
        {
            double menor = notas[0];

            for(int i=0;i < notas.Count; i++)
            {
                if(menor > notas[i])
                {
                    menor = notas[i];
                }
            }

            return menor;
        }
        private void CalcBT_Click(object sender, EventArgs e)
        {
            List<Double> notas = new List<Double>();
            notas.Add(Convert.ToDouble(nota1TB.Text));
            notas.Add(Convert.ToDouble(nota2TB.Text));
            notas.Add(Convert.ToDouble(nota3TB.Text));
            Double soma = 0;

            for (int i=0; i < notas.Count; i++)
            {
                if (notas[i] != CalcMenor(notas))
                {
                    soma += notas[i];
                }
                
            }
            notaLB.Text = Convert.ToString(soma /2);
        }
    }
}
