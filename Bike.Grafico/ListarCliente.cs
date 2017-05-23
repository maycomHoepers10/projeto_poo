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
            ConfigurarDg();
        }


        private void ConfigurarDg()
        {
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientes.ColumnCount = 2;
            dgClientes.ColumnHeadersVisible = true;
            dgClientes.Columns[0].Name = "CPF";
            dgClientes.Columns[0].DataPropertyName = "Cpf";
            dgClientes.Columns[1].Name = "Nome";
            dgClientes.Columns[1].DataPropertyName = "Nome";

            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
            cadastro.FormClosed += Tela_FormClosed;
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }
    }
}
