using Pizzaria.Domain;
using Pizzaria.Processors;

namespace Pizzaria.Builders.Base
{
    public abstract class PizzaBuilderBase
    {
        protected Pizza Pizza = null;
        protected readonly ICalculaValor CalculaValor;
        protected PizzaBuilderBase(ICalculaValor calculaValor)
        {
            this.CalculaValor = calculaValor;
        }

        public virtual void ValorPizza()
        {
            CalculaValor.ValorPizza(Pizza);
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }
        protected void Init()
        {
            Pizza = new Pizza();
        }
    }
}
