using BlazorTraining.Models;

namespace BlazorTraining.State
{
    public class OrderState
    {
        private List<FruitSalad> _fruitSalads = new List<FruitSalad>();
        public IEnumerable<FruitSalad> FruitSalads => _fruitSalads;

        public OrderState()
        {
        }

        public event Action? OnChange;

        public void AddFruitSalad(FruitSalad fruitSalad)
        {
            _fruitSalads.Add(fruitSalad);
            NotifyStateChanged();
        }

        public void DeleteFruitSalad(FruitSalad fruitSaled)
        {
            _fruitSalads.Remove(fruitSaled);
            NotifyStateChanged();
        }

        public void Clear()
        {
            _fruitSalads.Clear();
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
