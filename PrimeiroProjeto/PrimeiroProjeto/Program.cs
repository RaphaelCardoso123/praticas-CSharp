using PrimeiroProjeto;
using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Course {
    class Program {
        static void Main(string[] args) {

   
            Console.WriteLine("Digite a quantidade de notas a ser calculada: ");
            int quantNotas = Convert.ToInt32(Console.ReadLine());

            double notas = 0;
            for (int i = 1; i <= quantNotas; i++) {
                Console.WriteLine("Digite as notas: ");
                notas = Convert.ToDouble(Console.ReadLine());
            }

            double media;
            media = notas / quantNotas;
            Console.WriteLine("A média do aluno foi de " + media );

            if (media >= 60) {
                Console.WriteLine("Parabéns, você passou!!");
            } else if(media >= 40){
                Console.WriteLine("Você ficou de recuperação!!");
            } else {
                Console.WriteLine("Você foi reprovado!!");
            }

            Console.Write("Deseja calcular outra média (s/n)? ");
            char outraMedia = Convert.ToChar(Console.ReadLine());

            
            //if(outraMedia == "s" || outraMedia == "S") {
             // Console.WriteLine("Digite a quantidade de notas a ser calculada: ");
             // quantNotas = Convert.ToInt32(Console.ReadLine());
            //}


            /*
            Console.WriteLine("Digite a quantidade de notas a ser calculada: ");
            int quantNotas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite as notas: ");
            double notas = Convert.ToDouble(Console.ReadLine());

            double media;

            for (int i = 1; i <= quantNotas; i++) {
                //media = notas  / quantNotas;
                //Console.WriteLine("A média é: " + media);
                media = (notas + i) / quantNotas;
                Console.WriteLine("A média é: " + media); 
            }

            /*
            for (int i = 0; i == quantNotas; i++) { 
                media = (notas + notas) / quantNotas;
                Console.WriteLine("A média é: " + media);
            }
            */








            /*
            Conta c;
            double Saldo;

            Console.Write("Entre com o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o títular da conta: ");
            string TitularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n)");
            char DepositoConta = char.Parse(Console.ReadLine());

            if(DepositoConta == 's' || DepositoConta == 'S'){
                Console.Write("Entre com o valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(NumeroConta , TitularConta, deposito);
            } else {
                c = new Conta(NumeroConta, TitularConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            //;;
            Console.WriteLine("Deseja fazer saque? (s/n)");
            char SaqueConta = char.Parse(Console.ReadLine());

            if (SaqueConta == 's' || SaqueConta == 'S') {
                Console.Write("Entre com valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(NumeroConta, TitularConta, Saldo);
            } else {
                c = new Conta(NumeroConta, TitularConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizada:");
            Console.WriteLine(c);

            //Console.WriteLine();
            //Console.Write("Entre com o valor para saque: ");
            //double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //c.Sacar(saque);

            //Console.WriteLine();
            //Console.WriteLine("Dados da conta atualizada:");
            //Console.WriteLine(c);
            */






            /*
    Produto p = new Produto();
    Console.WriteLine("Digite os dados do produto: ");
    Console.WriteLine("Nome: ");
    p.Nome = Console.ReadLine();
    Console.WriteLine("Preço: ");
    p.Preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade: ");
    p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(); //só para pular uma linha
    Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
    Console.WriteLine("Quantidade de produto adicionado? ");
    int qtd = int.Parse(Console.ReadLine());
    p.AdicionarProduto(qtd);
            Console.WriteLine();
    Console.WriteLine("Dados atualizados:" + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto removido? ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            */
            //----------------------------------------------------------------------------
            /*
            *(25) PROPERTIES / AUTOPROPERTIES (CLASSE PRODUTO)
            Produto p = new Produto("Tv", 900.00, 10);
            p.Nome = "Laptop"; //Usando properties
            Console.WriteLine(p.Nome);//Usando properties
            Console.WriteLine(p.Preco);//Usando properties. Só se escreve na tela pq ñ foi feito o Set na classe Produtos
            Console.WriteLine(p.Quantidade);//Usando properties. Só se escreve na tela pq ñ foi feito o Set na classe Produtos
            //p.SetNome("Laptop");
            //Console.WriteLine(p.GetNome());
            //p.SetPreco(2300);
            //Console.WriteLine(p.GetPreco());
            //p.SetQuantidade(5);
            //Console.WriteLine(p.GetQuantidade());
            */




            /*
            *(24) SOBRECARGA (CLASSE PRODUTO)
            Console.WriteLine("Digite os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine(); //só para pular uma linha
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto adicionado? ");         
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto removido? ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            /*



            /*
            *(23) CONSTRUTORES (CLASSE PRODUTO)
            Console.WriteLine("Digite os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine ();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine(); //só para pular uma linha
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto adicionado? ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto removido? ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            */




            /*
            *(22) STATIC
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */



            /*
            *(21) STATIC
            Calculadora calc = new Calculadora();
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */



            /*
            *(20) STATIC
            Console.Write("Qual a cotação do dólar de hoje? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você deseja comprar??");
            double qtd = double.Parse(Console.ReadLine());  
            double result = ConversorDeMoeda.DolarParaReal(cotacao, qtd);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            *(19) TOSTRING / OBJECT / ATRIBUTOS / MÉTODOS
            Aluno a = new Aluno();
            Console.WriteLine("Digite o nome do aluno: ");
            a.Nome = (Console.ReadLine());
            Console.WriteLine("Nome do aluno: " + a.Nome);
            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);           
            Console.WriteLine();
            Console.WriteLine("NOTA FINAL= " + a.ResultadoFinal(), CultureInfo.InvariantCulture);
            if (a.Aprovado()) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            };
            */



            /*
            *(18) TOSTRING / OBJECT / ATRIBUTOS / MÉTODOS
            Funcionario f = new Funcionario();
            Console.WriteLine("Digite o nome do funcionário: ");
            f.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o salário bruto do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor a ser descontado de imposto : ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);          
            Console.WriteLine();
            Console.WriteLine("O nome do funcionário é " + f);           
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar no salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);          
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
            */



            /*
            *(17) TOSTRING / OBJECT / ATRIBUTOS / MÉTODOS
            Retangulo r = new Retangulo();
            Console.WriteLine("Digite a largura e altura do retângulo: ");
            Console.WriteLine("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
             */



            /*
            *(16) TOSTRING / OBJECT / ATRIBUTOS / MÉTODOS (CLASSE PRODUTO)
            Produto p = new Produto ();
            Console.WriteLine("Digite os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine ();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());           
            Console.WriteLine(); //só para pular uma linha
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto adicionado? ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            Console.WriteLine();
            Console.WriteLine("Quantidade de produto removido? ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            */


            /*
            *(15) EXERCICIOS / CLASSE / METODOS
            SalariomMedio p1 = new SalariomMedio();
            SalariomMedio p2 = new SalariomMedio();
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double medio = (p1.Salario + p2.Salario) / 2;
            Console.WriteLine("Salário médio = " + medio.ToString ("F2", CultureInfo.InvariantCulture));
            */


            /*
            *(15) EXERCICIOS / CLASSE / METODOS
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());        
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            if( p1.Idade > p2.Idade) {
                Console.WriteLine("A pessoa mais velha é a(o): " + p1.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha é a(o): " + p2.Nome);
            }
            */


            /*
            *(14) EXERCICIOS / WHILE
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;           
            Console.WriteLine("Qual combustivel você vai abastecer?");
            Console.WriteLine("1 = Alcool, 2 = Gasolina, 3 = Diesel, 4 = nenhum");           
            int tipo = int.Parse(Console.ReadLine());          
            while (tipo != 4) {
                if (tipo == 1) {
                    alcool += +1;
                }
            else if (tipo == 2) {
                    gasolina += +1;
                }
            else if (tipo == 3) {
                    diesel += +1;
                }
                tipo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado pela preferência!!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            */


            /*
            *(10) EXERCICIOS
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2022) {
                Console.WriteLine("Senha inválida...Digite sua senha.");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!!!");
            */


            /*
            *(13)FUNÇÃO 
            Console.WriteLine("Digite três números..");                 //USÚARIO DIGITA 3 NÚMEROS
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);                       //PROGRAMA CHAMA A FUNÇÃO QUE CALCULA O MAIOR
            Console.WriteLine("O maior número foi o " + resultado);     //MOSTRA NA TELA O RESULTADO
        }
        static int Maior(int a, int b, int c) {                         //ESSA É A FUNÇÃO
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
         //}
         */


            /*
            *(12) EXERCICIOS
            Console.WriteLine("Digite um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor inteiro: ");
            int y = int.Parse(Console.ReadLine());
            if (x % y == 0) {
                Console.WriteLine("São multiplos!");
            } else {
                Console.WriteLine("Não são multiplos!");
            };
            */


            /*
            *(11) EXERCICIOS
            Console.WriteLine("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            if( x >= 0 ) {
                Console.WriteLine("POSITIVO");
            }else {
                Console.WriteLine("NEGATIVO");
            };


            /*
            *(10) EXERCICIOS
            Console.WriteLine("Código da peça 1: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça 1: ");
            double val1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Código da peça 2: ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de peça 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça 1: ");
            double val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pagar = (num1 * val1) + (num2 * val2);
            Console.WriteLine("VALOR A PAGAR: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            */


            /*
            *(9) EXERCICIOS 
            Console.WriteLine("Insira o código do funcionário: ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira as horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de sua hora: ");
            double valHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valHoras;
            Console.WriteLine("NUMBER = " + cod);
            Console.WriteLine("SALARY = U$ " + salario.ToString("f2", CultureInfo.InvariantCulture));
            */


            /*
    while (true) {
                Console.Write("Digite a quantidade de notas que serão calculadas: ");
                int qNotas = Convert.ToInt32(Console.ReadLine());
                double sumNotas = 0;
        char continuar = '.';
                for (int nota = 1; nota <= qNotas; nota++) {
                Console.Write($"Digite a {nota}° nota: ");
                sumNotas += Convert.ToDouble(Console.ReadLine());
                }
                double media = Math.Round(sumNotas / qNotas, 2);
                Console.WriteLine($"A média do aluno é de: {media}");
        if (media >= 6) {
            Console.WriteLine("Está Aprovado");
        }
        else {
            Console.WriteLine("Está Repovado");
        }
        do {
            try {
                Console.Write("Deseja escrever a nota para outro aluno(S/N) ?: ");
                continuar = Convert.ToChar(Console.ReadLine().ToLower());
            }
            catch {
                Console.WriteLine("Digite um opção valida (S/N)");
            }
        } while (continuar != 's' && continuar != 'n');

        if (continuar == 'n') {
            Console.WriteLine("Até logo!");
            break;
        }
    }
    */

            /*
            *(8) EXERCICIOS 
            Console.WriteLine("Insira um número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira mais um número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira mais um número: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o último número: ");
            int d = int.Parse(Console.ReadLine());
            int diferenca = (a * b) - (c * d);
            Console.WriteLine("DIFERENÇA = " + diferenca);
            */


            /*
            *(7) EXERCICIOS 
            //PRIM.OPÇÃO
            Console.WriteLine("Entre com um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com mais um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("SOMA = " + num3);
            //SEG.OPÇÃO
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int c = a + b;
            Console.WriteLine("SOMA = " + c);
            */


            /*
            *(6)  VETOR,SPLIT,PARSE /  TOSTRING("F2,CULTUREINFO.INVARIANTCULTURE / inserindo dados+espaço e dados+enter
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura: ");           
            string[] dados = Console.ReadLine().Split(' ');
            string ultNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);
            Console.WriteLine("SEUS DADOS FORAM: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(dados[0]); // Posso colocar "ultNome" que tm dá certo
            Console.WriteLine(dados[1]); // Posso colocar "idade" que tm dá certo
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture)); //Se colocar "dados[2]" não d´´a certo!!??
            */


            /*
            *(5) VETOR /  TOSTRING("F2,CULTUREINFO.INVARIANTCULTURE / (dessa forma cada dado inserido precisa + Espaço)
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Seus dados foram: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[2]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[3]);
            Console.WriteLine(vet[0]);
            */


            /*
            *(4) PARSE / CULTUREINFO.INVARIANTCULTURE / (dessa forma cada dado inserido precisa + Enter)
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            */


            /*
            *(3) SPLIT / CONSOLE.READLINE
            string s = Console.ReadLine(); //Outra maneira é tirar essa parte..
            string[] vet = s.Split(' ');   //string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p2);
            */


            /*
            *(2) SAÍDA DE DADOS / PLACEHOLDER, INTERPOLAÇÃO, CONCATENAÇÃO
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
            */


            /*
            *(1) SAÍDA DE DADOS / CONCATENAÇÃO, CULTUREINFO.INVARIANTCULTURE
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