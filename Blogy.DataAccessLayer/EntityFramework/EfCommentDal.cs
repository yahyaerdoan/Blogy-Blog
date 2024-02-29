using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;

namespace Blogy.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
    }
}
