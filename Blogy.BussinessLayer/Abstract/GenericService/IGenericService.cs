using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Abstract.GenericService
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        void TAdd(TEntity entity);
        void TDelete(int id);
        void TUpdate(TEntity entity);
        List<TEntity> TGetListAll();
        TEntity TGetById(int id);
    }
}
