using System;
using Microsoft.EntityFrameworkCore;

namespace JwtAuth.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

}
