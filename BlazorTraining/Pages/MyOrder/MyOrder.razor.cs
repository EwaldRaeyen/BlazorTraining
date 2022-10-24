using BlazorTraining.Models;
using BlazorTraining.State;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Pages.MyOrder
{
    public partial class MyOrder: ComponentBase
    {
        [Inject] public OrderState State { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        private IEnumerable<FruitSalad> FruitSalads => State.FruitSalads;

        private void OnDelete_Click(FruitSalad fruitSalad)
        {
            State.DeleteFruitSalad(fruitSalad);
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

    }
}
