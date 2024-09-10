using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    internal class CategoryRepository : ICategoryDal
    {
        Context c= new Context();
        DbSet<Category> _object;
        public void Delete(Category P)
        {
            _object.Remove(P);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category P)
        {
            _object.Add(P);
            c.SaveChanges();


        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category P)
        {
            c.SaveChanges();
        }
    }
}
