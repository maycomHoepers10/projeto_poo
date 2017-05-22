using Bike.Negocio;
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

        public ListarBilicleta()
        {
            InitializeComponent();
            ConfigurarDg();
        }

        private void ConfigurarDg()
        {
            dgBicicletas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBicicletas.ColumnCount = 5;
            dgBicicletas.ColumnHeadersVisible = true;
            dgBicicletas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Bicicleta> bicicletas = Util.Gerenciador.BicicletasCadastradas();
            dgBicicletas.DataSource = bicicletas;
        }

        private void ListarBilicleta_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroBicicleta cadastro = new TelaCadastroBicicleta();
            cadastro.FormClosed += Tela_FomClosed;
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void Tela_FomClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }
    }
}
