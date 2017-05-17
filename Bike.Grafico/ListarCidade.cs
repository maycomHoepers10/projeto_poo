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
    public partial class ListarCidade : Form
    {
        public ListarCidade()
        {
            InitializeComponent();
        }

        private void ListarCidade_Load(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaAdicionarCidade cadastro = new TelaAdicionarCidade();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();

        }
    }
}
