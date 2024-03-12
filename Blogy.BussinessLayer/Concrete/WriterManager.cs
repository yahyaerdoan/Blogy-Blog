using Blogy.BussinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.EntityLayer.Concrete;

namespace Blogy.BussinessLayer.Concrete
{
    public class WriterManager : IWrierService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TAdd(Writer entity)
        {
            _writerDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _writerDal.Delete(id);
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> TGetListAll()
        {
            return _writerDal.GetListAll();
        }

        public void TUpdate(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
