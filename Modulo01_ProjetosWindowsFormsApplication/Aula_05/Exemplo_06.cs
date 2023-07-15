using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            SplitContainer splitContainer = new SplitContainer();
            splitContainer.Dock = DockStyle.Fill;

            Button button1 = new Button();
            button1.Text = "Botão 1";

            Button button2 = new Button();
            button2.Text = "Botão 2";

            splitContainer.Panel1.Controls.Add(button1);
            splitContainer.Panel2.Controls.Add(button2);

            this.Controls.Add(splitContainer);
        }
    }
}
