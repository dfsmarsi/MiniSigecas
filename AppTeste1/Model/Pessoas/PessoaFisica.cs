namespace AppTeste1.Model.Pessoas
{
    public class PessoaFisica : Pessoa
    {
        public int Cpf { get; set; }
        public int Rg { get; set; }

        public PessoaFisica(int id, string nome, string email, int cpf, int rg)
            : base(id, nome, email)
        {
            Cpf = cpf;
            Rg = rg;
        }
    }
}