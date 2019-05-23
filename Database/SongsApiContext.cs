using Microsoft.EntityFrameworkCore;
using songsapi.Models;

namespace songsapi.Database {
    public class SongsApiContext : DbContext {
        
        public SongsApiContext(DbContextOptions<SongsApiContext> options) : base(options) {}

        public DbSet<Song> Songs {get; set;}

    }
}