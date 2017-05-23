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
    public partial class TelaAdicionarLocacao : Form
    {
        public TelaAdicionarLocacao()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        private void ConfigurarComboBox()
        {
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "Cod";
        }

        private void CarregarComboBox()
        {
            List<Cidade> cidades = Util.Gerenciador.CidadesCadastradas();
            cbCidade.DataSource = cidades;
        }

        private void TelaAdicionarLocacao_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            List<Local> locais = Util.Gerenciador.LocaisCadastrados();
            var novoCod = locais.Max(bicicleta => bicicleta.Cod) + 1;
            tbCod.Text = novoCod.ToString();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Local locacao = new Local();
                locacao.Codigo = Convert.ToInt64(tbCod.Text);
                locacao.nmLocal = tbLocal.Text;
                locacao.Endereco = tbEndereco.Text;
                locacao.Cidade = Util.Gerenciador.BuscarCidadePorCodigo(Convert.ToInt64(cbCidade.SelectedValue));
                locacao.vlBikeNormal = Convert.ToDecimal(tbValorNormal.Text);
                locacao.vlBikeEletrica = Convert.ToDecimal(tbValorEletrica.Text);

                Util.Gerenciador.AdicionarLocal(locacao);
                MessageBox.Show("Local de Locação cadastrado com Sucesso!");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
