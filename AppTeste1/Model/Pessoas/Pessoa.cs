using System.Collections.Generic;

namespace AppTeste1.Model.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();

        public Pessoa(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}