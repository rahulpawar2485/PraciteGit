﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GITPracitice.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Practice1Controller : ControllerBase
    {
        // GET: api/<Practice1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Practice1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Practice1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Practice1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Practice1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
