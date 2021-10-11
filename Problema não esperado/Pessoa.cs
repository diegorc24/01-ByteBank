using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_não_esperado
{
    public class Pessoa
    {
        public string nome;
        public string cpf;
        public int idade;
        public Endereco endereco =  new Endereco();
    }
}
