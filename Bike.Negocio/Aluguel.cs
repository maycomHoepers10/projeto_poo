using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Negocio
{
    public class Aluguel
    {
        public long Cod { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Cliente Cliente { get; set; }
        public Bicicleta Bicicleta { get; set; }

    }
}
