using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Produto {

        /*------------------------------------------------------*/
        private string _nome;//Encapsulamento (private) (_nome)
        private double _preco;
        private int _quantidade;
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        public Produto() {
        }
        /*------------------------------------------------------*/
        //construtor, Encapsulamento (_nome)
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _quantidade = quantidade;
            _preco = preco;  
        }
        /*------------------------------------------------------*/
        //Sobrecarga, Encapsulamento (_nome)
        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
            _quantidade = 10; 
        }
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        //Encapsulamento (Get)
        public string GetNome() {
            return _nome;
        }
        public double GetPreco() {
            return _preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }




        /*------------------------------------------------------*/
        //Encapsulamento (_nome)
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            _quantidade -= quantidade;
        }
        /*------------------------------------------------------*/


        /*------------------------------------------------------*/
        //Encapsulamento (_nome)
        public override string ToString() {
            return _nome
                   + ", $ "
                   + _preco.ToString("F2", CultureInfo.InvariantCulture)
                   + " , "
                   +_quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        /*------------------------------------------------------*/
    }
}

