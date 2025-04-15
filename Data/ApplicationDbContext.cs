using my_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace my_tracker.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) {}
}