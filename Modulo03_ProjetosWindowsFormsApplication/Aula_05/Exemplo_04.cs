using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Location = new System.Drawing.Point(50, 50);
            flowLayoutPanel.Size = new System.Drawing.Size(300, 50);

            Button button1 = new Button();
            button1.Text = "Botão 1";

            Button button2 = new Button();
            button2.Text = "Botão 2";

            Button button3 = new Button();
            button3.Text = "Botão 3";

            flowLayoutPanel.Controls.Add(button1);
            flowLayoutPanel.Controls.Add(button2);
            flowLayoutPanel.Controls.Add(button3);

            this.Controls.Add(flowLayoutPanel);
        }
    }
}
