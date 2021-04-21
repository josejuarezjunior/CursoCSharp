using System.Globalization;

namespace Encapsulamento_AutoProperties
{
    class Produto
    {
        /*
         * O atributo "_nome" possui uma lógica particular, por isso a Auto Property não é aplicada
         * nesse caso. Sendo assim, sua implementação de propriedade permanece manual.
        */
    
        private string _nome;
        public double Preco { get; private set; }//O "private" impede o atributo de ser diretamente modificado.
        public int Quantidade { get; private set; }


        //Construtores
        public Produto()
        {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this()//O "this" nesse caso está reaproveitando o construtor sem parâmetros
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)////O "this" nesse caso está reaproveitando o construtor com dois parâmetros
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

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

        //Métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}