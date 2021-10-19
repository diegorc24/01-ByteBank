//using _07_ByteBank;
using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
  
        public Cliente Titular { get; set; }

        public int Numero 
        { get;  }

        public static double TaxaOperacao { get; private set; }

        public int Agencia
        { get; }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0 || numero <= 0)
            {
               
                //Queremos lançar uma exceçao
            }

            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;

        }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;

            }
        }

        public bool Sacar(double valor)
        {
            
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }


            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }
}