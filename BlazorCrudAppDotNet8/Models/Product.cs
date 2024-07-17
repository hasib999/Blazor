using System.ComponentModel.DataAnnotations;

namespace BlazorCrudAppDotNet8.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
