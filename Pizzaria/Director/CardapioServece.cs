using Pizzaria.Builders.Base;
using Pizzaria.Domain;
using Pizzaria.Domain.ValueObject;

namespace Pizzaria.Director
{
    public class CardapioServece
    {
        public void PizzaSemBordaRecheada(IPizzaBuilder pizzaBuilder, Tamanho tamanho)
        {
            pizzaBuilder.PreparaMassa(tamanho);
            pizzaBuilder.EscolheIngredientes();
            pizzaBuilder.ValorPizza();
        }

        public void PizzaComBordaRecheada(IPizzaBuilder pizzaBuilder, Tamanho tamanho, Borda borda)
        {
            pizzaBuilder.PreparaMassa(tamanho);
            pizzaBuilder.EscolheIngredientes();
            pizzaBuilder.PreparaBorda(borda);
            pizzaBuilder.ValorPizza();
        }
    }
}