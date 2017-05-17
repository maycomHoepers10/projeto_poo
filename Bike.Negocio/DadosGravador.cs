using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Negocio
{
    public class DadosGravador
    {
        public List<Cliente> Clientes { get; set; }
        public List<Bicicleta> Bicicletas { get; set; }
        public List<Cidade> Cidades { get; set; }
        public List<Local> Locais { get; set; }
        public List<Aluguel> Alugueis { get; set; }

        public DadosGravador()
        {
            this.Clientes = new List<Cliente>();
            this.Bicicletas = new List<Bicicleta>();
            this.Cidades = new List<Cidade>();
            this.Locais = new List<Local>();
            this.Alugueis = new List<Aluguel>();
        }
    }
}
