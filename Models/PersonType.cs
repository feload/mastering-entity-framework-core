using System.Collections.Generic;

namespace ContactsCore
{
  public class PersonType
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Person> People { get; set; }
  }
}