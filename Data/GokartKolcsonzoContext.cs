using GameStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data;

public class GokartkolcsonzoContext(DbContextOptions<GokartkolcsonzoContext> options) : DbContext(options)
{
    public DbSet<Berles> Berles => Set<Berles>();
    public DbSet<Berlo> Berlo => Set<Berlo>();
    public DbSet<Gokart> Gokart => Set<Gokart>();

    
}
