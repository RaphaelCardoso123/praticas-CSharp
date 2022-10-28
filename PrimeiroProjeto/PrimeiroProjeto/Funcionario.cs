using System;


namespace PrimeiroProjeto {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario() {
            return SalarioBruto *
        }
    }
}
