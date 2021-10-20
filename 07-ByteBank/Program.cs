using System;
using System.Collections.Generic;
using System.IO;
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
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }
                Console.WriteLine("Execuçao finalizada. Tecle enter para sair");

            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {

                leitor.LerProximaLinha();
            }
            //----------------------------------------------------------------
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //   leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

               
            //}
           
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1, 1);
                ContaCorrente conta2 = new ContaCorrente(2, 2);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informaçoes da INNER EXCEPTION (exceçao interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
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
            try
            {
                int resultado = Dividir(10, divisor);
            }
             catch(NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NullReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Exception ex)");
                Console.WriteLine(ex.StackTrace);
            }

            // catch(DivideByZeroException ex)
            //  {
            //      Console.WriteLine(ex.StackTrace);
            //  }
            Console.WriteLine("Estou executando normalmente!");
           
        }
        private static int Dividir(int numero, int divisor)
        {
           try
            {
                Console.WriteLine("Fazendo o calculo " + numero + " / " + divisor);
                int resultado =  numero / divisor;
                Console.WriteLine("O resultado e " + resultado);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no calculo: " + ex.Message);
                throw;// Lançar exceçao
                Console.WriteLine("Depois do throw");
            }

          
        }
    }
}
