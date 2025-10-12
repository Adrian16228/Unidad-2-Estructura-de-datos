namespace EjemploChecarSintaxis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRevisarCadena_Click(object sender, EventArgs e)
        {
            string strCadena=txtCadena.Text;
            for (int i = 0; i < strCadena.Length; i++)
            {
                char caracter = strCadena[i];
                MessageBox.Show(caracter.ToString());
            }
        }
    }
}
