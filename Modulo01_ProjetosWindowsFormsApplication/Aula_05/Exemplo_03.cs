using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
            TabControl tabControl = new TabControl();
            tabControl.Location = new System.Drawing.Point(50, 50);
            tabControl.Size = new System.Drawing.Size(300, 200);
            
            TabPage tabPage1 = new TabPage();
            tabPage1.Text = "Guia 1";
            
            Label label1 = new Label();
            label1.Text = "Conteúdo da guia 1";
            label1.Location = new System.Drawing.Point(10, 10);
            
            tabPage1.Controls.Add(label1);
            
            TabPage tabPage2 = new TabPage();
            tabPage2.Text = "Guia 2";
            
            Label label2 = new Label();
            label2.Text = "Conteúdo da guia 2";
            label2.Location = new System.Drawing.Point(10, 10);
            
            tabPage2.Controls.Add(label2);
            
            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);
            
            this.Controls.Add(tabControl);
        }
    }
}
