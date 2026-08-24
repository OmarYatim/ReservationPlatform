namespace ReservationPlatform.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ReservationPlatform.Domain;

public class PlatformContext : DbContext
{
    public DbSet<Member> Members { get; set; }
    public PlatformContext(DbContextOptions<PlatformContext> options) : base(options)
    {
    }
}
