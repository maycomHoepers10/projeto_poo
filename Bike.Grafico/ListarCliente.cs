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
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
        }



        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente cadastro = new TelaCadastroCliente();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void dgListarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
