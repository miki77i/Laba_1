using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Laba_1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Pacient> Pacients { get; set; }
        public virtual DbSet<Palata> Palatas { get; set; }
        public virtual DbSet<Otdelenie> Otdelenies { get; set; }
    }
}
