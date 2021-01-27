using System.ComponentModel.DataAnnotations;

namespace DesignPattern.ViewModels
{
    public class SaveProductModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}