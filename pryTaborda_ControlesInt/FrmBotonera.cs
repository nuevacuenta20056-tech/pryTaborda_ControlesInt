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
            
            FrmBotonera siguienteForm = new FrmBotonera();
            siguienteForm.Show();


        }
    }
}
