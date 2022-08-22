namespace Hipotenusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l1 = Convert.ToDouble(txtlado1.Text);
            double l2 = Convert.ToDouble(txtlado2.Text);

            txtresultado.Text = (Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2))).ToString();


        }
    }
}