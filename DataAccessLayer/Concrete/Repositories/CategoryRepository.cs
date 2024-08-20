using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public void Insert(Category P)
        {
            _object.Add(P);
            c.SaveChanges();


        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category P)
        {
            c.SaveChanges();
        }
    }
}
