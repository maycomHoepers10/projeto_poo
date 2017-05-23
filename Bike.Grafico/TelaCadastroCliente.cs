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
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            tbCpf.Text = "";
            tbNome.Text = "";
            tbEmail.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.CPF = tbCpf.Text;
                cliente.Nome = tbNome.Text;
                cliente.Email = tbEmail.Text;
                Util.Gerenciador.AdicionarCliente(cliente);

                LimparCampos();
                MessageBox.Show("Cliente adicionado com sucesso!");
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
