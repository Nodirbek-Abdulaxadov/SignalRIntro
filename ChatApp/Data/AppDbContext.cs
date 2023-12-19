using ChatApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}