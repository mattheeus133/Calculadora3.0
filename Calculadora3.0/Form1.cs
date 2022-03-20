using Calculadora2._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculadora3._0
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sairStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fechar a Aplicação
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Atenção", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            } // quando aperta no x para fechar o aplicativo dara esse messagem
        }

        private void calcStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();

        }

        private void moedaStripMenuItem_Click(object sender, EventArgs e)
        {
            Moeda moeda = new Moeda();
            moeda.Show();
        }



        /* private void OpenMdiForm<F>() where F : Form, new()
         {
             var frm = this.MdiChildren.FirstOrDefault(f => f.GetType() == typeof(F));

             if (frm == null)
                 frm = new F();

             if (frm.MdiParent == null)
                 frm.MdiParent = this;

             frm.Show();
             frm.Focus();

             if (frm.WindowState == FormWindowState.Minimized)
                 frm.WindowState = FormWindowState.Normal;
         }*/
    }
}