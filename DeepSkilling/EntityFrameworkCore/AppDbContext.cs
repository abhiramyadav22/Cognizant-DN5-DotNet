using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public DbSet<Student> Students
    {
        get; set;
    }
}