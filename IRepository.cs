using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDAL
{
   public  interface IRepository
    {
        IEnumerable GetAll();
        dynamic GetbyId(int id);
    }
}
