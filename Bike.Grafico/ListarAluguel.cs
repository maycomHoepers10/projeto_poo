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
    public partial class ListarAluguel : Form
    {
        public ListarAluguel()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroAluguel cadastro = new TelaCadastroAluguel();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
