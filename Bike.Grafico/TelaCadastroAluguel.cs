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
    public partial class TelaCadastroAluguel : Form
    {
        private long CodAlguel;

        public TelaCadastroAluguel()
        {
            InitializeComponent();
            ConfigurarComboBox();
        }

        private void TelaCadastroAluguel_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            List<Aluguel> alugueis = Util.Gerenciador.AlugueisCadastrados();
            CodAlguel = (alugueis.Max(aluguel => aluguel.Cod) == 0) ? alugueis.Max(aluguel => aluguel.Cod) + 1 : 1;
        } 

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluguel aluguel = new Aluguel();
                aluguel.Cliente = new Cliente();
                aluguel.Bicicleta = new Bicicleta();
            

                aluguel.Cod = CodAlguel;
                aluguel.DataRetirada = DateTime.ParseExact(tbDataRetirada.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);


                Cliente cli = new Cliente();
                Bicicleta bic = new Bicicleta();


                String clienteCpf = Convert.ToString(cbCliente.SelectedValue);
                cli = Util.Gerenciador.BuscarClientePorCodigo(clienteCpf);
                aluguel.Cliente = cli;

                Int64 bicicletaCod = (Int64)cbBicicleta.SelectedValue;
                aluguel.Bicicleta = Util.Gerenciador.BuscarBicicletaPorCodigo(bicicletaCod);

                Util.Gerenciador.CadastrarAluguel(aluguel);
                MessageBox.Show("Bicicleta Cadastrada com Sucesso!");
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigurarComboBox()
        {
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "CPF";

            cbBicicleta.DisplayMember = "Modelo";
            cbBicicleta.ValueMember = "Cod";
        }

        private void CarregarComboBox()
        {
            List<Cliente> clientes = Util.Gerenciador.ClientesCadastrados();
            cbCliente.DataSource = clientes;

            List<Bicicleta> bicicletas = Util.Gerenciador.BicicletasCadastradas();
            cbBicicleta.DataSource = bicicletas;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
