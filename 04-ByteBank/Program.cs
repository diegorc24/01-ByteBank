using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoBruno = new ContaCorrente();

            contadoBruno.titular = "Bruno";

            Console.WriteLine(contadoBruno.saldo);

            bool resultadoSaque = contadoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contadoBruno.saldo);

            contadoBruno.Depositar(500);
            Console.WriteLine(contadoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            bool resulatodatransferencia = contadoBruno.Transferir(2000, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado transferência: " + resulatodatransferencia);

            contaDaGabriela.Transferir(100, contadoBruno);

            Console.WriteLine("Saldo do Bruno: " + contadoBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);



            Console.ReadLine();

        }
    }
}
