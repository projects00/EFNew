using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDAL
{
   public  class GRepository<T> where T: class
    {
      readonly  myTestEntities test = new myTestEntities();
        public IEnumerable<T> GetAll()
        {
            return test.Set<T>().ToList();
        }

        public T GetbyId(int id)
        {
            return test.Set<T>().Find(id);
        }

        public void Insert(T obj)
        {
            test.Set<T>().Add(obj);
            test.SaveChanges();
        }

        public void Update( T obj)
        {
             test.Entry(obj).State = EntityState.Modified;
            test.SaveChanges();
         }

        public void Delete(int id)
        {
          var dd = test.Set<T>().Find(id);
            test.Entry(dd).State = EntityState.Deleted;
            test.SaveChanges();
        }
       
    }
}
