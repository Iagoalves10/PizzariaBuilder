using Pizzaria.Domain;
using Pizzaria.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
