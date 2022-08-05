using AppTeste1.Model.Pessoas;
using System;
using System.Collections.Generic;

namespace AppTeste1.Model.Venda
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Pessoa Cliente { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Pedido(int id, DateTime data, Pessoa cliente)
        {
            Id = id;
            Data = data;
            Cliente = cliente;
        }
    }
}