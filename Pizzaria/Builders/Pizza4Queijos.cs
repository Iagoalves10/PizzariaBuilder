using Pizzaria.Builders.Base;
using Pizzaria.Domain;
using Pizzaria.Domain.ValueObject;
using Pizzaria.Processors;

namespace Pizzaria.Builders
{
    public sealed class Pizza4Queijos : PizzaBuilderBase, IPizzaBuilder
    {
        public Pizza4Queijos(ICalculaValor calculoValor) : base(calculoValor)
        {
        }

        public void PreparaBorda(Borda borda)
        {
            this.Pizza.Borda = borda;
        }

        public void PreparaMassa(Tamanho tamanho)
        {
            this.Init();

            this.Pizza.Tamanho = Tamanho.Família;
            this.Pizza.Tamanho = tamanho;
        }

        public void EscolheIngredientes(TipoIngrediente tipoIngrediente)
        {
            this.Pizza.Sabor = "4 QUEIJOS";
            this.Pizza.TipoIngrediente =
                TipoIngrediente.Mussarela |
                TipoIngrediente.Provolone |
                TipoIngrediente.QueijoMinas |
                TipoIngrediente.Majericao;
        }

        public void EscolheIngredientes()
        {
            this.Pizza.Sabor = "4 QUEIJOS";
            this.Pizza.TipoIngrediente =
                TipoIngrediente.Mussarela |
                TipoIngrediente.Provolone |
                TipoIngrediente.QueijoMinas |
                TipoIngrediente.Majericao;
        }

        public void PreparaMassa(TipoPizza tipoPizza)
        {
            this.Pizza.TipoPizza = TipoPizza.Salgada;
            this.Pizza.TipoPizza = tipoPizza;
        }
    }
}