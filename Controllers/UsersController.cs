using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using suretree.Services;

namespace suretree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IPerson pe;

            public UsersController(IPerson p)
        {
            pe = p;
        }
        
        [HttpGet("person/{int Id}")]
        public async Task<ActionResult> GetPerson(int Id)
        {
            return Ok(pe.GetById(Id));
        }

        [HttpPost]
        public async Task<ActionResult> Person(User u)
        {
            return Ok(pe.Insert(u));
        }

        [HttpGet("person")]
        public async Task<IEnumerable<User>> ListUser()
        {
            return Ok(pe.list());
        }


    }
}
