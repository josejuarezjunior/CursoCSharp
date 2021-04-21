using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        /*
         * Pela convenção da linguagem C#, atributos privativos
         * começam com underline(_) e a primeira palavra em letra
         * minúscula. Exemplo: "_metodo", "_outroMetodo".
         * 
         * Como esses atributos são privativos(private), seu acesso
         * se dá através das propriedades(properties) Get e Set.
        */

        private string _nome;
        private double _preco;
        private int _quantidade;


        //Construtores
        public Produto()
        {
            _quantidade = 0;
        }
        public Produto(string nome, double preco) : this()//O "this" nesse caso está reaproveitando o construtor sem parâmetros
        {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade): this(nome, preco)////O "this" nesse caso está reaproveitando o construtor com dois parâmetros
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }
        //Métodos que dão acesso aos atributos privativos
        //Dão acesso aos atributos, de maneira segura.

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double SetPreco(double preco)
        {
            return _preco = preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public int SetQuantidade(int quantidade)
        {
            return _quantidade = quantidade;
        }

        //Métodos
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}