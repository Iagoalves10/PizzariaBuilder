using Pizzaria.Builders;
using Pizzaria.Builders.Base;
using Pizzaria.Director;
using Pizzaria.Domain;
using Pizzaria.Processors;

namespace Pizzaria
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calValor = new CalculoPizza();

            IPizzaBuilder pizza4queijosBuilder = new Pizza4Queijos(calValor);
            IPizzaBuilder pizzaEmpalhadaBuilder = new PizzaEmpalhada(calValor);

            var cardapioService = new CardapioServece();

            cardapioService.PizzaComBordaRecheada(pizzaEmpalhadaBuilder, Domain.ValueObject.Tamanho.Grande,
                new Borda
                {
                    TipoBorda = TipoBorda.Chocolate
                });

            var pizzaEmpalhada1 = pizzaEmpalhadaBuilder.GetPizza();

            cardapioService.PizzaSemBordaRecheada(pizzaEmpalhadaBuilder, Domain.ValueObject.Tamanho.Grande);

            // PIZZA 2

            cardapioService.PizzaComBordaRecheada(pizza4queijosBuilder, Domain.ValueObject.Tamanho.Família,
                new Borda
                {
                    TipoBorda = TipoBorda.Catupiry
                });

            var pizza4queijos1 = pizza4queijosBuilder.GetPizza();

            View("Pizza 1:", pizzaEmpalhada1);
            View("Pizza 3:", pizza4queijos1);
        }

        public static void View(string msg, Pizza pizza)
        {
            Console.WriteLine($"{pizza.Sabor} / {pizza.Valor:C} / {pizza.TipoPizza.ToString()}");
        }
    }
}