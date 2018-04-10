using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDAL
{
   public  class EmployeeRepository : IRepository
    {
        myTestEntities test = new myTestEntities();
        public IEnumerable GetAll()
        {
           return  test.Employees.ToList();
        }

        public dynamic GetbyId(int id)
        {
            return test.Employees.Find(id);
        }
        public IEnumerable GetAll1()
        {
            return test.empreport().ToList();
        }
    }
}
