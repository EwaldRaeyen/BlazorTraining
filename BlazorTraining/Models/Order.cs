using System.ComponentModel.DataAnnotations;

namespace BlazorTraining.Models
{
    public class Order
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public Address Address { get; set; }
    }
}
