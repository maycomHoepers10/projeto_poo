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
    public partial class TelaAdicionarCidade : Form
    {

        public TelaAdicionarCidade()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tbNome.Text = "";
            tbCod.Text = "";
        }

        private void TelaAdicionarCidade_Load(object sender, EventArgs e)
        {
            List<Cidade> cidades = Util.Gerenciador.CidadesCadastradas();
            var novoCod = cidades.Max(cidade => cidade.Cod) + 1;
            tbCod.Text = novoCod.ToString();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cidade cidade = new Cidade();
                cidade.Cod = Convert.ToInt64(tbCod.Text);
                cidade.Nome = tbNome.Text;
                Util.Gerenciador.AdicionarCidade(cidade);
                MessageBox.Show("Cidade cadastrada com Sucesso!");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
