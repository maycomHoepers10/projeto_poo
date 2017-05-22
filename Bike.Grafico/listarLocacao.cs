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
    public partial class listarLocacao : Form
    {
        public listarLocacao()
        {
            InitializeComponent();
            ConfigurarDg();
        }


        private void ConfigurarDg()
        {
            dgLocacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLocacoes.MultiSelect = false;
            dgLocacoes.ColumnCount = 2;
            dgLocacoes.ColumnHeadersVisible = true;
            dgLocacoes.Columns[0].Name = "Identificador";
            dgLocacoes.Columns[0].DataPropertyName = "Codigo";
            dgLocacoes.Columns[1].Name = "Local";
            dgLocacoes.Columns[1].DataPropertyName = "nmLocal";
            dgLocacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLocacoes.SelectionChanged += DgLocacoes_SelectionChanged;
        }

        private void DgLocacoes_SelectionChanged(object sender, EventArgs e)
        {
     
        }

        private void CarregarDados()
        {
            List<Local> locais = Util.Gerenciador.LocaisCadastrados();
            dgLocacoes.DataSource = locais;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void listarLocacao_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaAdicionarLocacao cadastro = new TelaAdicionarLocacao();
            cadastro.FormClosed += Tela_FormClosed;
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }
        
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }

        private void dgLocacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
