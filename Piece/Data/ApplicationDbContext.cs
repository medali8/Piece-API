using Microsoft.EntityFrameworkCore;
using Piece.Models.Entities;
using Piece.Models.Entities;
namespace Piece.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ApplicationDbContext dbcontext;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Pieces> piece { get; set; }


    }
}
