using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ContaCorrente conta = new ContaCorrente(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           
                Metodo();
           
                Console.WriteLine("Execuçao finalizada. Tecle enter para sair");

            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
            //try
            //{
            //Console.WriteLine("TRY: inicio");
            //TestaDivisao(0);
            // TestaDivisao(20);
            // Console.WriteLine("TRY: fim");
            //}
            // catch (DivideByZeroException ex)
            // {
           // Console.WriteLine("Mensagem: " + ex.Message);
            //Console.WriteLine("Rastro da pilha: " + ex.StackTrace);
            //Console.WriteLine("Ops, erro DivideByZeroException");

            // }

        }
        private static void TestaDivisao(int divisor)
        {
           
                int resultado = Dividir(10, divisor);
                Console.WriteLine("resultado da divisao de 10 por " + divisor + " e " + resultado);   
           
        }
        private static int Dividir(int numero, int divisor)
        {
           try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceçao com numero=" + numero + " e divisor=" + divisor);
                throw;
                Console.WriteLine("Codigo depois do throw");
            }

          
        }
    }
}
