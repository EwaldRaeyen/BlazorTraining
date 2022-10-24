using System.ComponentModel.DataAnnotations;

namespace BlazorTraining.Models
{
    public class Address
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public int Number { get; set; }
        public int? BoxNumber { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string City { get; set; }
    }
}
