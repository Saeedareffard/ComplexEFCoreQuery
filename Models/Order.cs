using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeLinq.Models;

public class Order
{
    [Key]
    public int OrderID { get; set; }

    [ForeignKey("Customer")]
    public int CustomerID { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    public virtual Customer Customer { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}