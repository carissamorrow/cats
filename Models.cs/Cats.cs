using System.ComponentModel.DataAnnotations;

namespace Cats.Models
{
  public class Cat
  {
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }


    public Cat(string name, string desc)
    {
      Name = name;
      Description = desc;
    }
  }
}