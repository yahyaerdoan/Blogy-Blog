using Blogy.BussinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;

namespace Blogy.BussinessLayer.Concrete
{
    public class AricleManager : IArticleService
    {
        private readonly IArticleDal _articledal;

        public AricleManager(IArticleDal articledal)
        {
            _articledal = articledal;
        }

        public void TAdd(Article entity)
        {
            _articledal.Add(entity);
        }

        public void TDelete(int id)
        {
            _articledal.Delete(id);
        }

        public Article TGetById(int id)
        {
            return _articledal.GetById(id);
        }

        public List<Article> TGetListAll()
        {
            return _articledal.GetListAll();
        }

        public void TUpdate(Article entity)
        {
            _articledal.Update(entity);
        }
    }
}
