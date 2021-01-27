using System.ComponentModel.DataAnnotations;

namespace DesignPattern.ViewModels
{
    public class SaveCategoryModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}