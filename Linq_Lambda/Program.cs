using System;
using System.Collections.Generic;
using System.Linq;
using Linq_Lambda.Entities;

namespace Linq_Lambda
{

    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            Console.WriteLine("------------------------ Testes com Linq ------------------------");

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("TIER 1 AND PRICE < 900: ", r1);

            /*
            * Aqui são selecionados todos os itens que são da categoria
            * Tools. Porém para não serem mostrados todos os atributos
            * do objeto, é usado um comando Select, para mostrar apenas 
            * os nomes dos objetos.
            */
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            /*
            * Aqui são selecionados todos os itens quem tem o nome
            * começado pela letra 'C'. Para isso é utilizado o comando
            * Where, filtrando pelo índice 'O' e após isso é utilizado
            * o comando Select junto com uma função anônima(uma função
            * que não é declarada em lugar algum, apenas dentro desse
            * Select), escolhendo para visualização os campos Name
            * Price e Category.Name.
            * No caso de Category.Name, é necessário criar um alias
            * (CategoryName), pois já há uma categoria Name nessa função
            * e portanto há um conflito.
            * O objeto anônimo tem um ToString Padrão.
            */
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", r3);

            /*
            * Aqui são selecionados todos os itens com Tier = 1
            * e ordenados pelo preço crescente utilizando o comando
            * OrderBy(para ordenar de forma decrescente é utilizado 
            * OrderByDescending).
            * Se houverem itens com valor igual, então serão ordenados
            * pelo nome, utilizando o comando ThenBy.
            */
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            /*
            * Irá utilizar os itens do exemplo anterior, pulando
            * doi itens(Skip) e selecionando 4 itens(Take).
            */

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            /*
            * Para encontrar o primeiro item da lista é utilizado o comando
            * First. Porém caso a consulta não tenha itens e seja visualização
            * será gerada uma excessão e irá "quebrar" a aplicação.
            * Para contornar esse problema, deve ser utilizado o tratamento 
            * de erro (Try/Catch) ou ainda utilizando o comando FirstOrDefault,
            * que em caso de erro irá retornar o valor padrão do objeto,
            * nesse caso, Null.
            */

            var r6 = products.FirstOrDefault();
            Console.WriteLine("Fist or default test1: " + r6);

            //Esse caso irá retornar nullo:
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("Fist or default test2: " + r7);

            /*
            * O comando SingleOrDefault é utilizado quando a
            * busca irá gerar apenas um resultado ou nenhum.
            * Um exemplo é o caso de Id, que em tese, é um
            * valor único.
            * Caso a busca não tenha resultado, será mostrado
            * o valor default(padrão), que nesse caso é null.
            */
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default teste1: " + r8);

            //Essa operação retorna null:
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default teste2: " + r9);

            //Operação que retorna o maior preço
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            //Operação que retorna o menor preço
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            /*
            * Essa operação filtra os produtos com Id = 1.
            * Após isso é feita a soma dos preços desses
            * produtos, com o comando Sum.
            */
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            /*
            * Essa operação filtra os produtos com Id = 1.
            * Após isso é calculada a média dos preços desses
            * produtos, com o comando Average.
            */
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            /*
            * Abaixo progamação defensiva para caso a lista seja vazia.
            * Nesse caso primeiro são selecionados os preços e caso
            * seja uma lista vazia(Empty) será atribuído o valor 0.
            * Assim então será calculada a média(Average). 
            */
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 1 Average prices: " + r14);

            /*
            * Abaixo uma função que faz a lógica de uma soma.
            * Primeiramente é selecionado o campo de preço(Price),
            * e após isso é feita uma função anônima com uma 
            * expressão lambda.
            */
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + " : ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
