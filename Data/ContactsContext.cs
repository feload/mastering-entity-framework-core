using Microsoft.EntityFrameworkCore;

namespace ContactsCore.Data
{
  public class ContactsContext : DbContext {
    public ContactsContext (DbContextOptions<ContactsContext> options) :base(options)
    {

    }
    public DbSet<Person> People { get; set; }
  }
}