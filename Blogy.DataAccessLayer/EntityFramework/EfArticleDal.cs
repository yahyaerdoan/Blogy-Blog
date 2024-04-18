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

        public List<Article> GetArticlesByWriterId(int id)
        {
            var values = _context.Articles.Where(a=> a.AppUserId == id).ToList();
			return values;
        }

        public List<Article> GetArticlesWithWriter()
		{
			var values = _context.Articles.
				Include(a=> a.Writer).
				Include(a=> a.Category).
				ToList();
			return values;
		}

        public Writer GetWriterInfoByArticleWriter(int id)
        {
            var values = _context.Articles.Where(a=> a.ArticleId == id).Select(b=> b.Writer).FirstOrDefault();
			return values;
        }
    }
}