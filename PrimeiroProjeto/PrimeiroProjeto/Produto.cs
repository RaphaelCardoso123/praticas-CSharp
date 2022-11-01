using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Produto {

        /*------------------------------------------------------*/
        public string Nome;
        public double Preco;
        public int Quantidade;
        /*------------------------------------------------------*/
        //construtor
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;  
        }
        /*------------------------------------------------------*/
        //Sobrecarga
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 10; 
        }
        /*------------------------------------------------------*/
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }
        /*------------------------------------------------------*/
        public override string ToString() {
            return Nome
                   + ", $ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + " , "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        /*------------------------------------------------------*/
    }
}

