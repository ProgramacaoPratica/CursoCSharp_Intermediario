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

        private void btnExibirMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, mundo!");
        }
    }
}
