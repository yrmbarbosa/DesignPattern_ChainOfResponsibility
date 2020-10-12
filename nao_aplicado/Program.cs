using System;

namespace nao_aplicado
{
    class Program
    {
        static void Main(string[] args)
        {

            Orcamento orcamento = new Orcamento();

            orcamento.AdicionaItem(new Item("Arroz", 100));
            orcamento.AdicionaItem(new Item("Feijão", 200));
            orcamento.AdicionaItem(new Item("Batata", 300));
            orcamento.AdicionaItem(new Item("Alface", 400));
            orcamento.AdicionaItem(new Item("Tomate", 500));
            orcamento.AdicionaItem(new Item("Bife", 600));

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(orcamento.Valor);
            Console.WriteLine(desconto);

            Console.ReadKey();

        }
    }
}
