using Gokart.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gokart.Data;

public class GokartkolcsonzoContext(DbContextOptions<GokartkolcsonzoContext> options) : DbContext(options)
{
    public DbSet<Berles> Berles => Set<Berles>();
    public DbSet<Berlo> Berlo => Set<Berlo>();
    public DbSet<Gokartok> Gokartok => Set<Gokartok>();

    
}
