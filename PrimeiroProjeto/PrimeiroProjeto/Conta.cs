using System;


namespace PrimeiroProjeto {
    internal class Conta {


        public int NumeroConta;
        public string TitularConta;
        public double Saldo;
        public string DepositoConta;
//public double Deposito;


        public void Depositar(double deposito) {
            deposito += Saldo;
        }

        public override string ToString() { 
            return "Conta: " + NumeroConta + ", Titular: " 
                   + TitularConta + ", Saldo: $" + Saldo.ToString("F2");

        }

    }
}