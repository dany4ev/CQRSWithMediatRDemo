using Microsoft.EntityFrameworkCore;

namespace CQRSWithMediatR.EF_Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, 
    IConfiguration configuration) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
    }
}