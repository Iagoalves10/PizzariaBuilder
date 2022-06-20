using Pizzaria.Domain;
using Pizzaria.Domain.ValueObject;

namespace Pizzaria.Builders.Base
{
    public interface IPizzaBuilder
    {
        void PreparaBorda(Borda borda);

        void PreparaMassa(Tamanho tamanho);

        void EscolheIngredientes();

        void ValorPizza();

        Pizza GetPizza();

        void PreparaMassa(TipoPizza tipoPizza);
    }
}