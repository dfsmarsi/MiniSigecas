using MiniSigecas.Model.Pessoa.Enum;
using MiniSigecas.Pessoa.Endereco.Model;
using System.Collections.Generic;

namespace MiniSigecas.Pessoa.Model
{
    public abstract class PessoaModel
    {
        public int Id;
        public string Nome;
        public List<EnderecoModel> ListaEndereco = new List<EnderecoModel>();
        public TipoPessoa TipoPessoa;
        public bool Desativado;
    }
}
