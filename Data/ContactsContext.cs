using Microsoft.EntityFrameworkCore;

namespace ContactsCore.Data
{
  public class ContactsContext : DbContext {
    public ContactsContext (DbContextOptions<ContactsContext> options) :base(options)
    {

    }
    public DbSet<Person> People { get; set; }
    public DbSet<Person> PersonPhone { get; set; }
    public DbSet<PersonType> PersonType { get; set; }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
      modelBuilder
        .Entity<Person>()
        .Property(p => p.Height)
        .HasColumnType("decimal(5,2)")
        .IsRequired(true);
    }
  }
}