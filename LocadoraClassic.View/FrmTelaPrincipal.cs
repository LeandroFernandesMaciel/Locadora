using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void gráficoPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gráficoBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaGenero frmTelaGenero = new FrmTelaGenero();
            frmTelaGenero.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCategoria frmTelaCategoria = new FrmTelaCategoria();
            frmTelaCategoria.Show();

        }
    }
}
