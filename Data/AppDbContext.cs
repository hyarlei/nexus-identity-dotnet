using Microsoft.EntityFrameworkCore;
using NexusIdentity.Models;

namespace NexusIdentity.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Essa linha diz: "Crie uma tabela 'Users' baseada na classe 'User'"
    public DbSet<User> Users { get; set; }
}