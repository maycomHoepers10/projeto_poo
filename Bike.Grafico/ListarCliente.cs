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
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            List<Cliente> clientes = Util.Gerenciador.ClientesCadastrados();
            dgClientes.DataSource = clientes;
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroCliente cadastro = new TelaCadastroCliente();
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }
    }
}
