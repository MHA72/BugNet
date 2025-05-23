using BugNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BugNet.Data;

public class BugDbContext(DbContextOptions<BugDbContext> options) : DbContext(options)
{
    public DbSet<Bug> Bugs { get; set; }
}