using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        private readonly BlogyContext _context;
        public void Add(TEntity entity)
        {
            var values =_context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var values =_context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(values);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetListAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
