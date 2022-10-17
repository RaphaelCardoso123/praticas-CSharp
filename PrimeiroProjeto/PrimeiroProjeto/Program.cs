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

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é ${1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3",CultureInfo.InvariantCulture));


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