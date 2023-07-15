using System;
using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormExibicao : Form
    {
        public FormExibicao(string dados)
        {
            InitializeComponent();

            lblDados.Text = dados;
        }
    }
}
