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
    public class CateforyRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _objectt;

        public void Delete(Category p)
        {
            _objectt.Remove(p);
            c.SaveChanges();

        }

        public void Insert(Category p)
        {
            _objectt.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _objectt.ToList();  
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
