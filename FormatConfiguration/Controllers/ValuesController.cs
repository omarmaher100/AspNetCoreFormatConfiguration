using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormatConfiguration.Model;

namespace FormatConfiguration.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Produces("application/xml")]
        public List<Employee> Get()
        {
            return new List<Employee> { new Employee { Id = 1, FirstName = "Omar", LastName = "Maher" },
                                        new Employee { Id = 2, FirstName = "Ahmed", LastName = "Ali" }};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var employees = new List<Employee> { new Employee { Id = 1, FirstName = "Omar", LastName = "Maher" },
                                        new Employee { Id = 2, FirstName = "Ahmed", LastName = "Ali" }};

            return employees.Where(e=>e.Id == id).Select(e=>e).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
