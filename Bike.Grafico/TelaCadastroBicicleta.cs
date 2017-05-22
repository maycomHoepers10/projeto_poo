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
using System.Globalization;

namespace Bike.Grafico
{
    public partial class TelaCadastroBicicleta : Form
    {
        public TelaCadastroBicicleta()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        private void ConfigurarComboBox()
        {
            cbLocais.DisplayMember = "Nome";
            cbLocais.ValueMember = "Cod";
        }

        private void CarregarComboBox()
        {
            List<Local> locais = Util.Gerenciador.LocaisCadastrados();
            cbLocais.DataSource = locais;
        }

        private void TelaCadastroBicicleta_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            List<Bicicleta> bicicletas = Util.Gerenciador.BicicletasCadastradas();
            var novoCod = bicicletas.Max(bicicleta => bicicleta.Cod) + 1;
            tbCod.Text = novoCod.ToString();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Bicicleta bicicleta = new Bicicleta();
                bicicleta.Cod = Convert.ToInt64(tbCod.Text);
                bicicleta.Marca = tbMarca.Text;
                bicicleta.Modelo = tbModelo.Text;
                bicicleta.DataCompra = DateTime.ParseExact(tbData.Text, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                bicicleta.Tipo = (rdNormal.Checked)? Convert.ToString(rdNormal.Text) : Convert.ToString(rdEletrica.Text);
                bicicleta.Local = Util.Gerenciador.BuscarLocalPorCodigo(Convert.ToInt64(cbLocais.SelectedValue));

                Util.Gerenciador.AdicionarBicicleta(bicicleta);
                MessageBox.Show("Bicicleta Cadastrada com Sucesso!");
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLocais_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboBox();
        }
    }
}
