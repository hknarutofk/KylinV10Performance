using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly sbtestContext context = new sbtestContext();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Sbtest1>> Get()
        {
            return context.Sbtest1.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Sbtest1> Get(int id)
        {
            var item = context.Sbtest1.Where(c => c.Id == id).SingleOrDefault();            
            return item;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Sbtest1 value)
        {
            context.Sbtest1.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sbtest1 value)
        {
            if (value.Id != id)
            {
                throw new Exception("id not equeal");
            }
            context.Sbtest1.Update(value);
            context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = context.Sbtest1.FirstOrDefault(c => c.Id == id);
            context.Sbtest1.Remove(item);
            context.SaveChanges();
        }
    }

}