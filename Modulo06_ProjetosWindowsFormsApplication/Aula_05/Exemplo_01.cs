using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(50, 50);
            panel.Size = new System.Drawing.Size(200, 200);
            
            Button button = new Button();
            button.Location = new System.Drawing.Point(10, 10);
            button.Text = "Clique aqui";
            
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(10, 40);
            
            panel.Controls.Add(button);
            panel.Controls.Add(textBox);
            
            this.Controls.Add(panel);
        }
    }
}
