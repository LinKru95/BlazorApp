

using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters.")]
        public string Name { get; set; }
        [Required]
        [Range(1,1000, ErrorMessage = "Valid price range is 1 to 1000.")]
        public decimal Price { get; set; }
    }
}
