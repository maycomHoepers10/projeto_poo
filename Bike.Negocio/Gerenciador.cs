using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.Negocio
{
    public class Gerenciador
    {
        private Gravador Gravador { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Bicicleta> Bicicletas { get; set; }
        public List<Cidade> Cidades { get; set; }
        public List<Local> Locais { get; set; }
        public List<Aluguel> Alugueis { get; set; }


        public Gerenciador()
        {
            this.Clientes = new List<Cliente>();
            this.Bicicletas = new List<Bicicleta>();
            this.Cidades = new List<Cidade>();
            this.Locais = new List<Local>();
            this.Alugueis = new List<Aluguel>();

            this.Gravador = new Gravador();
            this.Carregar();
        }

        public void Carregar()
        {
            DadosGravador dados = this.Gravador.Carregar();
            this.Clientes = dados.Clientes;
            this.Bicicletas = dados.Bicicletas;
            this.Cidades = dados.Cidades;
            this.Locais = dados.Locais;
            this.Alugueis = dados.Alugueis;

        }

        public void Salvar()
        {
            this.Gravador.Salvar(this.Clientes,
                                 this.Bicicletas,
                                 this.Cidades,
                                 this.Locais,
                                 this.Alugueis);
        }

        public List<Cliente> ClientesCadastrados()
        {
            return this.Clientes.ToList();
        }

        public List<Bicicleta> BicicletasCadastradas()
        {
            return this.Bicicletas.ToList();
        }

        public List<Cidade> CidadesCadastradas()
        {
            return this.Cidades.ToList();
        }

        public List<Local> LocaisCadastrados()
        {
            return this.Locais.ToList();
        }

        public List<Aluguel> AlugueisCadastrados()
        {
            return this.Alugueis.ToList();
        }

        /*Bucando código */
        public Cliente BuscarClientePorCodigo(String cpf)
        {
            return this.Clientes
                        .Where(cliente => cliente.CPF.Equals(cpf))
                        .FirstOrDefault();
        }

        public Bicicleta BuscarBicicletaPorCodigo(long codBicicleta)
        {
            return this.Bicicletas
                        .Where(bicicleta => bicicleta.Cod.Equals(codBicicleta))
                        .FirstOrDefault();
        }

        public Cidade BuscarCidadePorCodigo(long codCidade)
        {
            return this.Cidades
                        .Where(cidade => cidade.Cod.Equals(codCidade))
                        .FirstOrDefault();
        }

        public Local BuscarLocalPorCodigo(long codLocal)
        {
            return this.Locais
                        .Where(local => local.Cod.Equals(codLocal))
                        .FirstOrDefault();
        }


        public Aluguel BuscarAluguelPorCodigo(long codAluguel)
        {
            return this.Alugueis
                        .Where(Alugueis => Alugueis.Cod.Equals(codAluguel))
                        .FirstOrDefault();
        }





        public void AdicionarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("O cliente não pode ser nulo");

            if (String.IsNullOrEmpty(cliente.CPF))
                throw new Exception("O cliente precisa ter O CPF");

            if (String.IsNullOrEmpty(cliente.Nome))
                throw new Exception("O cliente precisa ter um nome");

            if (String.IsNullOrEmpty(cliente.Email))
                throw new Exception("O cliente precisa ter um email");

            this.Clientes.Add(cliente);
            this.Salvar();
        }

        public void AdicionarCidade(Cidade cidade)
        {
            if (cidade == null)
                throw new Exception("A bebida não pode ser nula");

            if (String.IsNullOrEmpty(cidade.Nome))
                throw new Exception("Informe o nome da Cidade");

            this.Cidades.Add(cidade);
            this.Salvar();
        }

        public void AdicionarBicicleta(Bicicleta bicicleta)
        {
            if (bicicleta == null)
                throw new Exception("A bicicleta não pode ser nula");

            if (String.IsNullOrEmpty(bicicleta.Marca))
                throw new Exception("Informe o tamanho a Marca");

            if (String.IsNullOrEmpty(bicicleta.Modelo))
                throw new Exception("Informe o modelo da Bicicleta");

            if (bicicleta.DataCompra == null)
                throw new Exception("Informe a data da Compra");

            if (String.IsNullOrEmpty(bicicleta.Tipo) && (bicicleta.Tipo != "E" && bicicleta.Tipo != "N"))
                throw new Exception("Informe o tipo da bicicleta");

            this.Bicicletas.Add(bicicleta);
            this.Salvar();
        }

        public void AdicionarLocal(Local local)
        {
            if (String.IsNullOrEmpty(local.nmLocal))
                throw new Exception("Informe o nome do local");

            if (String.IsNullOrEmpty(local.Endereco))
                throw new Exception("Informe o endereço");

            if (local.Cidade == null)
                throw new Exception("Informe o nome da cidade");

            if (local.vlBikeNormal < 0)
                throw new Exception("O valor não pode ser negativo");

            if (local.vlBikeEletrica < 0)
                throw new Exception("O valor não pode ser negativo");

            this.Locais.Add(local);
            this.Salvar();
        }

        public void CadastrarAluguel(Aluguel alu)
        {
            Aluguel aluguel = new Aluguel();
            aluguel = alu;
            if (aluguel == null)
                throw new Exception("O Aluguel não pode ser nulo");
            if (aluguel.DataRetirada == null || aluguel.DataRetirada == DateTime.MinValue)
                throw new Exception("Informe a data de retirada!");
            if (aluguel.Cliente == null)
                throw new Exception("Informe o cliente do aluguel");
            if (aluguel.Bicicleta == null)
                throw new Exception("Informe a bicicleta");
            Alugueis.Add(aluguel);
            this.Salvar();
        }

        public void CadastrarDevolucao(Aluguel aluguel)
        {
            if (aluguel == null)
                throw new Exception("O aluguel não pode ser nulo");

            if (aluguel.DataDevolucao == null || aluguel.DataRetirada == DateTime.MinValue)
                throw new Exception("Informe a data de devolução");

            this.Alugueis.Add(aluguel);
            this.Salvar();
        }



    }
   
}
