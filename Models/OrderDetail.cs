using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeLinq.Models;

public class OrderDetail
{
    [Key, Column(Order = 0)]
    [ForeignKey("Order")]
    public int OrderID { get; set; }

    [Key, Column(Order = 1)]
    [ForeignKey("Product")]
    public int ProductID { get; set; }

    [Required]
    public int Quantity { get; set; }

    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}