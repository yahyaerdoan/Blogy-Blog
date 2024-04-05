using Blogy.DataAccessLayer.Abstract.GenericDal;
using Blogy.EntityLayer.Concrete;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> GetArticlesWithWriter();
        Writer GetWriterInfoByArticleWriter(int id);
    }
}
