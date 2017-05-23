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
    public partial class ListarAluguel : Form
    {
        public ListarAluguel()
        {
            InitializeComponent();
            ConfigurarDg();
        }


        private void ConfigurarDg()
        {
            dgAlugueis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAlugueis.ColumnCount = 6;
            dgAlugueis.ColumnHeadersVisible = true;
            dgAlugueis.Columns[0].Name = "Código";
            dgAlugueis.Columns[0].DataPropertyName = "Cod";
            dgAlugueis.Columns[1].Name = "Data Retirada";
            dgAlugueis.Columns[1].DataPropertyName = "DataRetirada";
            dgAlugueis.Columns[2].Name = "Cliente";
            dgAlugueis.Columns[2].DataPropertyName = "Cliente";
            dgAlugueis.Columns[3].Name = "Bicicleta";
            dgAlugueis.Columns[3].DataPropertyName = "Bicleta";
            dgAlugueis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarDados()
        {
            List<Aluguel> alugueis = Util.Gerenciador.AlugueisCadastrados();
            dgAlugueis.DataSource = alugueis;
        }


        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void ListarAluguel_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroAluguel cadastro = new TelaCadastroAluguel();
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
