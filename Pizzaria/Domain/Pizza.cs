namespace Pizzaria.Domain

{
    using ValueObject;

    public class Pizza
    {
        public string? Sabor { get; set; }
        public Borda? Borda { get; set; }
        
        public TipoBorda TipoBorda { get; set; }
        public double Valor { get; set; }
        public Tamanho Tamanho { get; set; }
        public TipoPizza TipoPizza { get; set; }
        public TipoIngrediente TipoIngrediente { get; set; }
        
    
    }
}
