using DesignPattern.Domain.Models;

namespace DesignPattern.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse<Category>
    {
        public CategoryResponse(Category category) : base(category)
        { }
        public CategoryResponse(string message) : base(message)
        { }
    }
}