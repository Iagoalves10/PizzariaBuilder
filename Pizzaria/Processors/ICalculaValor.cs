using Pizzaria.Domain;

namespace Pizzaria.Processors
{
    public interface ICalculaValor
    {
        void ValorPizza(Pizza pizza);
    }
}