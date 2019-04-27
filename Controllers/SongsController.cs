using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using songsapi.Models;

namespace songsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // GET api/songs
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            var song = new Song() {
                Title = "Supermassive Black Hole",
                Artist = "Muse",
                CreatedAt = DateTime.Now,
                Id = 1
            };

            return new Song[] { song };
        }

        // GET api/songs/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"the id is {id}";
        }

        // POST api/songs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
