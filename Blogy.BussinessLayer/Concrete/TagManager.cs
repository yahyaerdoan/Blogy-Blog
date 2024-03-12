using Blogy.BussinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;

namespace Blogy.BussinessLayer.Concrete
{
    public class TagManager : ITagService
    {
        private readonly ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public void TAdd(Tag entity)
        {
            _tagDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _tagDal.Delete(id);
        }

        public Tag TGetById(int id)
        {
           return _tagDal.GetById(id);
        }

        public List<Tag> TGetListAll()
        {
            return _tagDal.GetListAll();
        }

        public void TUpdate(Tag entity)
        {
            _tagDal.Update(entity);
        }
    }
}
