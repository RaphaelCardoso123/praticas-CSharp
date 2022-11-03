using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Produto {

        /*------------------------------------------------------*/
        private string _nome;//Encapsulamento (private) 
        //private double _preco;//Quando se trabalha com private precisa usar o padrão _ e a primeira letra minúscula ex:(_nome)
        //private int _quantidade;
        public double Preco { get; private set; } //usando Auto Propreties
        public int Quantidade { get; private set; } //usando Auto Propreties
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        public Produto() {
        }
        /*------------------------------------------------------*/
        //construtor, Encapsulamento (_nome)
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            //_quantidade = quantidade;
            Quantidade = quantidade;
            //_preco = preco;
            Preco = preco;
        }
        /*------------------------------------------------------*/
        //Sobrecarga, Encapsulamento (_nome)
        //public Produto(string nome, double preco) {
        //   _nome = nome;
        //    _preco = preco;
        //    _quantidade = 10; 
        //}
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        /*------------------------------------------------------*/
        //Encapsulamento (Get)
        
        //Properties
        public string Nome {
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) { //usa "value" onde antes usava "nome"
                    _nome = value;                      //usa "value" onde antes usava "nome"
                }
            }
        }

        //public double Preco {
        //    get { return Preco; } //se ñ fizer o Set ñ permite que se altere o preço
        //}

        //public int Quantidade { //se ñ fizer o Set ñ permite que se altere a quantidade
        //   get { return Quantidade; }
        //}



        //Métodos
        /*
        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1) {//Exemplo de que pode ser feito
                _nome = nome;                    //"nome.Length > 1" é p/ que nome tenha mais de uma letra
            }
        }
        public double GetPreco() {
            return _preco;
        }
        public void SetPreco(double preco) { //Se eu ñ fizer o SetPreco eu ñ permito que seja alterado o preço, sómente o nome seria possivel por ter SetNome
            _preco = preco;
        }
        public int GetQuantidade() {
            return _quantidade;
        }
        public void SetQuantidade(int quantidade) {//Se eu ñ fizer o SetQuantidade eu ñ permito que seja alterado a quantidade, sómente o nome seria possivel por ter SetNome
            _quantidade = quantidade;
        }
        */


        /*------------------------------------------------------*/
        //Encapsulamento (_nome)
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


        /*------------------------------------------------------*/
        //Encapsulamento (_nome)
        public override string ToString() {
            return _nome
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

