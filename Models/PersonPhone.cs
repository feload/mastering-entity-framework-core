namespace ContactsCore
{
  public class PersonPhone
  {
    public int Id { get; set; }
    public string Phone { get; set; }

    public Person Person { get; set; }
  }
}