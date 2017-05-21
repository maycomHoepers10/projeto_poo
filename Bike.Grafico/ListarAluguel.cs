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
            cadastro.MdiParent = this.MdiParent;
            cadastro.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDados();
        }
    }
}
