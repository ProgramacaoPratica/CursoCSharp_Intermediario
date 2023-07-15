using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Location = new System.Drawing.Point(50, 50);
            tableLayoutPanel.Size = new System.Drawing.Size(300, 200);
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 2;

            Button button1 = new Button();
            button1.Text = "Botão 1";

            Button button2 = new Button();
            button2.Text = "Botão 2";

            Button button3 = new Button();
            button3.Text = "Botão 3";

            Button button4 = new Button();
            button4.Text = "Botão 4";

            tableLayoutPanel.Controls.Add(button1, 0, 0);
            tableLayoutPanel.Controls.Add(button2, 1, 0);
            tableLayoutPanel.Controls.Add(button3, 0, 1);
            tableLayoutPanel.Controls.Add(button4, 1, 1);

            this.Controls.Add(tableLayoutPanel);
        }
    }
}
