using System.ComponentModel.DataAnnotations;

namespace PracticeLinq.Models;

public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }
}