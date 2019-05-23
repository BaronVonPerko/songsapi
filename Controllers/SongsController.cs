using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using songsapi.Models;
using songsapi.Database;

namespace songsapi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {

        private SongsApiContext _dbContext;

        public SongsController(SongsApiContext dbContext) {
            _dbContext = dbContext;
        }

        // GET api/songs
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            var songs = _dbContext.Songs.ToList();

            return songs;
        }

        // GET api/songs/5
        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            var song = _dbContext.Songs.Find(id);

            return song;
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
