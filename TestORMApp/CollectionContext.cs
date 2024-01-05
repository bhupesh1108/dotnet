//use dotnet cli command
//dotnet add package Microsoft.EntityFramework

using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;
public class CollectionContext:DbContext{
    public DbSet<Department> Departments {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=192.168.10.150;port=3306;user=dac12; password=welcome;database=dac12";       
        optionsBuilder.UseMySQL(conString);
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
  
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Department>(entity => 
        {
            entity.Property(e => e.Deptno).IsRequired();
            entity.Property(e => e.Dname).IsRequired();
            entity.Property(e => e.Loc).IsRequired();
        });
        modelBuilder.Entity<Department>().ToTable("dept");
    }
}

