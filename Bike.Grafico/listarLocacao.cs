using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike.Grafico
{
    public partial class listarLocacao : Form
    {
        public listarLocacao()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaAdicionarLocacao cadastro = new TelaAdicionarLocacao();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }
    }
}
