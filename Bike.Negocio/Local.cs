using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Negocio
{
    public class Local : Cidade
    {
        public long Codigo { get; set; }
        public String nmLocal { get; set; }
        public String Endereco { get; set; }
        public Cidade Cidade{ get; set; }
        public decimal vlBikeNormal { get; set; }
        public decimal vlBikeEletrica { get; set; }
    }
}
