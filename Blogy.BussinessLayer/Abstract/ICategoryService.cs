using Blogy.BussinessLayer.Abstract.GenericService;
using Blogy.EntityLayer.Concrete;

namespace Blogy.BussinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TGetCategoryCount();
    }
}
