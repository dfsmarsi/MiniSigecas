namespace AppTeste1.Model.Pessoas
{
    public class PessoaJuridica : Pessoa
    {
        public int Cnpj { get; set; }
        public int Ie { get; set; }

        public PessoaJuridica(int id, string nome, string email, int cnpj, int ie) 
            : base(id, nome, email)
        {
            Cnpj = cnpj;
            Ie = ie;
        }
    }
}

