using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {


            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produto: ");
            Console.WriteLine("Computador, cujo preço é ${0:F2}", preco1);








            /*
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} com {1} anos de idade tem R${2:F2} de saldo no banco.", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e R${saldo:F2} no banco.");

            // Essa é a única forma possivel de passar o (.) no lugar da (,) usando => "saldo".ToString("F2",CultureInfo.InvariantCulture)
            Console.WriteLine(nome + " tem " + idade + " anos de idade e " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " de reais no banco." ); 
            */
              
        }
    }
}