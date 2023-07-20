using System;
using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            MessageBox.Show($"Você digitou: {texto}");
        }
    }
}
