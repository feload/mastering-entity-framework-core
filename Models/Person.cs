using System;
using System.ComponentModel.DataAnnotations;

namespace ContactsCore
{
    public class Person
    {
      public int Id { get; set; }

      [Required]
      [MaxLength(35)]
      public string FirstName { get; set; }

      [Required]
      [MaxLength(35)]
      public string LastName { get; set; }

      public decimal Height { get; set; }
      public bool IsActive { get; set; }
      public DateTime BirthDate { get; set; }
    }
}