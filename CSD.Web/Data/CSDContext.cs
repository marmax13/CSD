using CSD.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CSD.Web.Data;

public class CSDContext : DbContext
{
    public CSDContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Post> Posts { get; set; }

    private readonly CSDContext _db;

    public CategoriesController(CSDContext db)
    {
        _db = db;
    }


}
