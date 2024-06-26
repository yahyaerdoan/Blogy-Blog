﻿using Blogy.BussinessLayer.Abstract;
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
            if (entity.Title!= null && entity.Description.Length>50 && entity.CategoryId >=0)
            {
                entity.WriterId = 1;
                entity.CreatedDate = DateTime.Now;
                _articledal.Add(entity);
            }
            else
            {
                //throw exception
            }

        }

        public void TDelete(int id)
        {
            if (id !=  0)
            {
                _articledal.Delete(id);
            }
            else
            {
                //throw exception
            }
            
        }

        public List<Article> TGetArticlesByWriterId(int id)
        {
            return _articledal.GetArticlesByWriterId(id);
        }

        public List<Article> TGetArticlesWithWriter()
		{
			return _articledal.GetArticlesWithWriter();
		}

		public Article TGetById(int id)
        {
            return _articledal.GetById(id);
        }

        public List<Article> TGetListAll()
        {
            return _articledal.GetListAll();
        }

        public Writer TGetWriterInfoByArticleWriter(int id)
        {
            var values = _articledal.GetWriterInfoByArticleWriter(id);
            return values;
        }

        public void TUpdate(Article entity)
        {
            if(entity.Title is not null && entity.Description.Length > 50 && entity.CategoryId >= 0)
            {
                _articledal.Update(entity);
            }
            else
            {
                //throw exception
            } 
            
        }
    }
}