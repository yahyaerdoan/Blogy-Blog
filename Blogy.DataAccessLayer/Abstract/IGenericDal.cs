using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
        List<TEntity> GetListAll();
        TEntity GetById(int id);
    }
}
