using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;

namespace FanavaranBlog.Models;

public class DatabaseContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //base.OnConfiguring(options);
        options.UseSqlite($"data source=BlogDb.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Blog> Blogs { get; set; }
}
