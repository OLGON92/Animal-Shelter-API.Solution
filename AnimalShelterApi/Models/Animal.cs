using System.ComponentModel.DataAnnotations; 

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApi
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }

    public DateTime DateAdded { get; set; }
  }
}