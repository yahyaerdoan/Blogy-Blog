using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blogy.DataAccessLayer.EntityFramework
{
	public class EfArticleDal : GenericRepository<Article>, IArticleDal
	{
		BlogyContext _context = new BlogyContext();
		public List<Article> GetArticlesWithWriter()
		{
			var values = _context.Articles.
				Include(a=> a.Writer).
				Include(a=> a.Category).
				ToList();
			return values;
		}
	}
}
