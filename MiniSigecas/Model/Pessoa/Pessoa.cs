using MiniSigecas.Model.Pessoa.Enum;
using System.Collections.Generic;

namespace MiniSigecas.Model.Pessoa
{
    public abstract class Pessoa
    {
        public int Id;
        public string Nome;
        public List<Endereco> ListaEndereco = new List<Endereco>();
        public TipoPessoa TipoPessoa;
        public bool Desativado;

        public void Gravar()
        {

        }

        public void Alterar()
        {

        }

        public void Excluir()
        {
            Desativado = true;
        }
    }
}
