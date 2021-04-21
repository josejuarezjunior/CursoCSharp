using System.Globalization;

namespace EncapsulamentoII
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
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)////O "this" nesse caso está reaproveitando o construtor com dois parâmetros
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Propriedades manuais. Dão acesso aos atributos, de maneira segura.
        public string Nome
        {
            get { return _nome; }
            set//O atributo "value" nesse contexto, é o valor que será recebido como parâmetro no programa.
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
            
        }

        /*
         * As propriedades "Preco" e "Quantidade somente possuem o acessor "get",
         * ou seja, somente podem ter o seu valor, não podem alterar o valor, já que
         * não possuem o acessor "set", como a propriedade "Nome".
        */
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
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