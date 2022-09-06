namespace MiniSigecas.Model.Pessoa
{
    public class Endereco
    {
        public int Id;
        public string Rua;
        public string Numero;
        public int Cep;
        public string Bairro;

        public void PesquisarCep(int cep)
        {
            Rua = "Rua dos bobos";
            Numero = "0";
            Bairro = "Centro";
        }
    }
}
