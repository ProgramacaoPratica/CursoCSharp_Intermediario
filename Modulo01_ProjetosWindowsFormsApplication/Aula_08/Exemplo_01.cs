using System;
using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string dados = txtDados.Text;

            FormExibicao formExibicao = new FormExibicao(dados);
            formExibicao.Show();
        }
    }
}
