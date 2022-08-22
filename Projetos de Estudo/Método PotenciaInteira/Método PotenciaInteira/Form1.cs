namespace Método_PotenciaInteira
{
    public partial class Potencia : Form
    {
        public Potencia()
        {
            InitializeComponent();
        }

        private void btnchecar_Click(object sender, EventArgs e)
        {
            int b = 0;
            int n = 1;
            int expoente;
            int resultado;

            expoente = Convert.ToInt32(txtexpoente.Text);
            b = Convert.ToInt32(txtbase.Text);
            resultado = b;

            txtresultado.Text = txtbase.Text + " * ";

            while (n < expoente)
            {
                resultado *= b;

                if (n == (expoente - 1))
                {
                    txtresultado.Text = txtresultado.Text + (b + " = ");
                }
                else
                {
                    txtresultado.Text = txtresultado.Text +  (b + " * ");
                }

                n++;
            }

            txtresultado.Text = txtresultado.Text + resultado.ToString();

        }
    }
}