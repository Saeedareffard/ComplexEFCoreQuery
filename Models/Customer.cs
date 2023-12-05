using System.ComponentModel.DataAnnotations;

namespace PracticeLinq.Models;

public class Customer
{
    [Key]
    public int CustomerID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}