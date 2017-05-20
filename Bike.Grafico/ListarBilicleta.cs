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
    public partial class ListarBilicleta : Form
    {
        private object dgListarBicicleta;

        public ListarBilicleta()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroBicicleta cadastro = new TelaCadastroBicicleta();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void AtualizarDados()
        {
            List<bicicleta> bicicletas = Util.Gerenciador.BicicletasCadastradas();
            dgListarBicicleta.DataSource = bicicletas;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
