using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Models;

class PharmacyContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // TODO : Extract Connection string in resource file.
        optionsBuilder.UseSqlServer(
            "Server=PC;Database=Pharmacy;Trusted_Connection=True;Encrypt=False"
        );
    }
}
