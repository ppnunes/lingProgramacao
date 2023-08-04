namespace appExemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            double raio, areaCircunferencia;
            raio = Convert.ToDouble(txtRaio.Text);
        }
    }
}