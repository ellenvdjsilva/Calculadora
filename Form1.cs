namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somar_Click(object sender, EventArgs e)
        {
            int priNum, segNum, resultado;

            priNum = Int32.Parse(primeiroNumero.Text);

            segNum = Int32.Parse(segundoNumero.Text);

            resultado = priNum + segNum;

            somado.Text = resultado.ToString();
        }
    }
}