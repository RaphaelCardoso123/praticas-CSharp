using System;

namespace PrimeiroProjeto {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double DolarParaReal(double cotacao, double qtd) {
            double total = qtd * cotacao;
            return total + total * Iof / 100.0;

        }

    }
}
