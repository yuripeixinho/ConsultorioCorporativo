using CC.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CC.Data.Context;

public class CCContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    public CCContext(DbContextOptions options) : base(options)
    {}
}
