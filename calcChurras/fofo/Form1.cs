namespace fofo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qntHomem = 0;
            int qntMulher = 0;
            int qntcrianca = 0;
            if (homemTB.Text != "")
            {
                qntHomem = Convert.ToInt16(homemTB.Text);
            }
            if (mulherTB.Text != "")
            {
                qntMulher = Convert.ToInt16(mulherTB.Text);
            }
            if (criancaTB.Text != "")
            {
                qntcrianca = Convert.ToInt16(criancaTB.Text);
            }

            Double carne = (0.5 * qntHomem) + (0.3 * qntMulher) + (0.15 * qntcrianca);
            GeloLB.Text = Convert.ToString((1 * (qntHomem + qntMulher + qntcrianca))) + " Kg";
            RefriLB.Text = Convert.ToString((1 * (qntHomem + qntMulher + qntcrianca))) + " Litros";
            CervejaLB.Text = Convert.ToString((2 * (qntHomem + qntMulher))) + " Litros";
            FarofaLB.Text = String.Format("{0:0.00}", Convert.ToString((0.100 * (qntHomem + qntMulher)) + (0.50 * qntcrianca))) + " Kg";
            SaladaLB.Text = String.Format("{0:0.00}", Convert.ToString((0.100 * (qntHomem + qntMulher)) + (0.50 * qntcrianca))) + " Kg";
            CarneLB.Text = String.Format("{0:0.00}", Convert.ToString(carne)) + " Kg";
            CarvaoLB.Text = String.Format("{0:0.00}", Convert.ToString(1.5 * carne)) + " Kg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BomDiaLB_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}