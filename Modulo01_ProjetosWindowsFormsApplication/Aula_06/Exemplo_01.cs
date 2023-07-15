using System;
using System.Windows.Forms;

namespace MeuProjetoWindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        private int contador;

        public FormPrincipal()
        {
            InitializeComponent();
            
            contador = 0;
            
            Timer timer = new Timer();
            timer.Interval = 1000; // Intervalo de 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
        }
    }
}
