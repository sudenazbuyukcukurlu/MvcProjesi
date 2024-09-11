using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Category>, IWriterDal
    {
        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer Get(Expression<Func<Writer, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            throw new NotImplementedException();
        }

        List<Writer> IRepository<Writer>.List()
        {
            throw new NotImplementedException();
        }
    }
}
