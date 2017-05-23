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
    public partial class ListarCidade : Form
    {
        public ListarCidade()
        {
            InitializeComponent();
            ConfigurarDg();
        }

        private void ConfigurarDg()
        {
            dgCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCidades.ColumnCount = 2;
            dgCidades.ColumnHeadersVisible = true;
            dgCidades.Columns[0].Name = "Código";
            dgCidades.Columns[0].DataPropertyName = "Cod";
            dgCidades.Columns[1].Name = "Cidade";
            dgCidades.Columns[1].DataPropertyName = "Nome";
            dgCidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Cidade> cidades = Util.Gerenciador.CidadesCadastradas();
            dgCidades.DataSource = cidades;
        }

        private void ListarCidade_Load(object sender, EventArgs e)
        {
           CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaAdicionarCidade cadastro = new TelaAdicionarCidade();
            cadastro.FormClosed += Tela_FormClosed;
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
