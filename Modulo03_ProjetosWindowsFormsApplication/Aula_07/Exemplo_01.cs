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

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecundario formSecundario = new FormSecundario();
            formSecundario.MdiParent = this; // Define o formulário principal como o MDI Parent
            formSecundario.Show();
        }
    }
}
