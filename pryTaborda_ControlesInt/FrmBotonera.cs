namespace pryTaborda_ControlesInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBotonera_Click(object sender, EventArgs e)
        {
            //Crear instancia del siguiente formulario
            FrmBotonera siguienteForm = new FrmBotonera();

            //Mostrar el siguiente formulario
            siguienteForm.Show();


        }
    }
}
