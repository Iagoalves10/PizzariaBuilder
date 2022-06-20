using Pizzaria.Domain;
using Pizzaria.Domain.ValueObject;


namespace Pizzaria.Processors
{
    public class CalculoPizza : ICalculaValor
    {
        public void ValorPizza (Pizza pizza)
        {
            var totalIngredientes = Enum.GetValues(typeof(TipoIngrediente)).Cast<Enum>().Count(pizza.TipoIngrediente.HasFlag);
            var valorIngredientes = totalIngredientes * 2.0;
            var valorTamanho = (int)pizza.Tamanho * 10;
            var valorTipo = pizza.TipoPizza == TipoPizza.Doce ? 10 : 0;
            var valorBorda = 0;

            if (pizza.Borda == null)
            {
                return;
            }
            valorBorda = pizza.Borda.TipoBorda == TipoBorda.Chocolate
                ? (5 * (int)pizza.Borda.TipoBorda)
                : (3 * (int)pizza.Borda.TipoPizza);

            pizza.Valor = valorIngredientes + valorTamanho + valorTipo + valorBorda;
        }
       
    }
}
