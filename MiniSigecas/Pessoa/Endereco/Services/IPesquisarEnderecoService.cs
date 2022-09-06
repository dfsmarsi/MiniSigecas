using MiniSigecas.Pessoa.Endereco.Model;

namespace MiniSigecas.Pessoa.Endereco.Services
{
    public interface IPesquisarEnderecoService
    {
        EnderecoModel PesquisarEndereco(int cep);
    }
}
