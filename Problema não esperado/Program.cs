using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_não_esperado
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa guilherme = new Pessoa();
            
            guilherme.nome = "Guilherme";
            //guilherme.endereco = new Endereco();
            guilherme.endereco.logradouro = "Avenida XYZ";
            Console.WriteLine(guilherme.nome);
            Console.WriteLine(guilherme.endereco.logradouro);
            Console.ReadLine();
        }
    }
}
