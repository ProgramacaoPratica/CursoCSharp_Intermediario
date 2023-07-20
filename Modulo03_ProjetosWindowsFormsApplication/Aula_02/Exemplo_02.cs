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

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O botão foi clicado!");
        }
    }
}
