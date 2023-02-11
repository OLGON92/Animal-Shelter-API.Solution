using System.ComponentModel.DataAnnotations; 

namespace AnimalShelterApi.Models
{
  public class Animal 
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "You must enter a comment!")]
    public string Name { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "You must enter a species!")]
    public string Species { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "You must enter description!")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Please enter an age.")]
    public int Age { get; set; }

    public DateTime DateAdded { get; set; }
  }
}