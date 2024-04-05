using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;

namespace Blogy.DataAccessLayer.EntityFramework
{
	public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        BlogyContext _blogyContext =new BlogyContext();

		public List<Comment> GetCommentsByArticleId(int id)
		{
			var values = _blogyContext.Comments.Where(c=> c.ArticleId == id).ToList();
			return values;
		}
	}
}
