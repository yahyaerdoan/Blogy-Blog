using Blogy.DataAccessLayer.Abstract.GenericDal;
using Blogy.EntityLayer.Concrete;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int GetCategoyCount();
    }
}
