using Blogy.BussinessLayer.Abstract.GenericService;
using Blogy.EntityLayer.Concrete;

namespace Blogy.BussinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
		List<Comment> TGetCommentsByArticleId(int id);

	}
}
