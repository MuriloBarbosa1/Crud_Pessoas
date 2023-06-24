using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class Pessoa
    {
        private Pessoa() { }//Para não dar problema na hora de carregar
        public Pessoa(int id, string? nome, string? cpf, string? email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }
          //set recebe e get retorna set=get
        public int Id { get; private set; }
        public string? Nome { get; private set; }//? permite nulo
        public string? Cpf { get; private set; }
        public string? Email { get; private set; }
    }
}
