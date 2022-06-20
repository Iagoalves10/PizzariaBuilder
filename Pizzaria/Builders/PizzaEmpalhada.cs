using Pizzaria.Builders.Base;
using Pizzaria.Domain;
using Pizzaria.Domain.ValueObject;
using Pizzaria.Processors;

namespace Pizzaria.Builders
{
    public sealed class PizzaEmpalhada : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaEmpalhada(ICalculaValor calculaValor) : base(calculaValor)
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
            this.Pizza.Sabor = "EMPALHADA";
            this.Pizza.TipoIngrediente =
                TipoIngrediente.Mussarela |
                TipoIngrediente.BatataPalha |
                TipoIngrediente.QueijoMinas |
                TipoIngrediente.Bacon;
        }

        void IPizzaBuilder.EscolheIngredientes()
        {
            this.Pizza.Sabor = "EMPALHADA";
            this.Pizza.TipoIngrediente =
                TipoIngrediente.Mussarela |
                TipoIngrediente.BatataPalha |
                TipoIngrediente.QueijoMinas |
                TipoIngrediente.Bacon;
        }

        void IPizzaBuilder.PreparaMassa(TipoPizza tipoPizza)
        {
            this.Pizza.TipoPizza = TipoPizza.Salgada;
            this.Pizza.TipoPizza = tipoPizza;
        }
    }
}