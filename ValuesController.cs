using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using myDAL;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            GRepository<Employee> emp = new GRepository<Employee>();

            var result = emp.GetAll();
            return result;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]Employee pList)
        {
            GRepository<Employee> emp = new GRepository<Employee>();

            emp.Insert(pList);
            return "success";
        }

        // PUT api/values/5
        public string Put( [FromBody]Employee pList)
        {

            GRepository<Employee> emp = new GRepository<Employee>();
             emp.Update(pList);
            return "success";
        }

        // DELETE api/values/5
        public string Delete([FromUri]int id)

        {
            GRepository<Employee> emp = new GRepository<Employee>();
            emp.Delete(id);
            return "success";
        }

          [Route("stores/data")]
        [HttpGet]
        public IQueryable GetStore()
        {
            EmployeeRepository dd = new EmployeeRepository();

            var result = dd.GetAll1();
            return result.AsQueryable();
        }
    }
}
