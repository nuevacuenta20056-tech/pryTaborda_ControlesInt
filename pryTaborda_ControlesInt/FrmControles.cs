using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTaborda_ControlesInt
{
    public partial class FrmBotonera : Form
    {
        // Vector de Nombres
        private string[] nombres = { "Boca", "RiBer", "Racing", "San Lorenzo" };
        private int indice = 0;

        public FrmBotonera()
        {
            InitializeComponent();

            lblNombre.Text = nombres[indice];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            if (indice >= nombres.Length)
            {
                indice = 0;
            }
            lblNombre.Text = nombres[indice];
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            if (indice < 0)
            {
                indice = nombres.Length - 1;
            }
            lblNombre.Text = nombres[indice];
        }
    }
}
