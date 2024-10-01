using System;

namespace ExProjetoHotel.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
    }
}
