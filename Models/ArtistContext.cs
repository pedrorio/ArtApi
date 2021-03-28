using Microsoft.EntityFrameworkCore;

namespace ArtApi.Models
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(
            DbContextOptions<ArtistContext> options
        ) : base(options)
        {
        }

        public DbSet<ArtApi.Models.Artist> Artist { get; set; }
    }
}