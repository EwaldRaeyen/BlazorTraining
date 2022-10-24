using System.ComponentModel.DataAnnotations;

namespace BlazorTraining.Models
{
    public class Address
    {
        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 5)]
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
