using BlazorTraining.Models;
using BlazorTraining.State;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;

namespace BlazorTraining.Pages.Checkout
{
    public partial class Checkout
    {
        [Inject] public OrderState State { get; set; }

        public EditContext editContext;
        private Order _myOrder;
        private bool _isSubmitting = false;

        protected override void OnInitialized()
        {
            _myOrder = new Order
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Address = new Address
                {
                    Street = "AStreet",
                    Number = 1,
                    BoxNumber = null,
                    ZipCode = "1000",
                    City = "Brussel",
                }
            };
            editContext = new EditContext(_myOrder);

            base.OnInitialized();
        }

        private void PlaceOrder()
        {
            _isSubmitting = true;
        }
    }
}
