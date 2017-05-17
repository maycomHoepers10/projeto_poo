using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bike.Negocio
{
    public class Gravador
    {
        private String NomeArquivo = "dados.xml";

        public void Salvar(List<Cliente> clientes,
                           List<Bicicleta> bicicletas,
                           List<Cidade> cidades,
                           List<Local> locais,
                           List<Aluguel> alugueis)
        {
            DadosGravador dados = new DadosGravador();
            dados.Clientes = clientes;
            dados.Bicicletas = bicicletas;
            dados.Cidades = cidades;
            dados.Locais = locais;
            dados.Alugueis = alugueis;

            StreamWriter arquivo = new StreamWriter(NomeArquivo);
            XmlSerializer serializer = new XmlSerializer(typeof(DadosGravador));
            serializer.Serialize(arquivo, dados);
            arquivo.Close();
        }

        public DadosGravador Carregar()
        {
            DadosGravador dados = new DadosGravador();

            if (File.Exists(NomeArquivo))
            {
                StreamReader arquivo = new StreamReader(NomeArquivo);
                XmlSerializer serializer = new XmlSerializer(typeof(DadosGravador));
                dados = serializer.Deserialize(arquivo) as DadosGravador;
                arquivo.Close();
            }
            return dados;
        }
    }
}
