namespace BlazorTraining.Models
{
    public class FruitSalad
    {
        public List<Fruit> Fruits { get; set; } = new();

        public double GetPrice()
        {
            return Fruits.Select(s => s.Price).Sum();
        }
    }
}
