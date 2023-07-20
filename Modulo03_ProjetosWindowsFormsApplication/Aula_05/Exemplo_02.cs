using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
            GroupBox groupBox = new GroupBox();
            groupBox.Location = new System.Drawing.Point(50, 50);
            groupBox.Size = new System.Drawing.Size(200, 200);
            groupBox.Text = "Opções";
            
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new System.Drawing.Point(10, 20);
            checkBox1.Text = "Opção 1";
            
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Location = new System.Drawing.Point(10, 50);
            checkBox2.Text = "Opção 2";
            
            groupBox.Controls.Add(checkBox1);
            groupBox.Controls.Add(checkBox2);
            
            this.Controls.Add(groupBox);
        }
    }
}
