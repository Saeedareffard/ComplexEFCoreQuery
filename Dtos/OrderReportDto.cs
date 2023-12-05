namespace PracticeLinq.Dtos;

public class OrderReportDto
{
    public int CustomerId { get; set; }
    public int? FistTopProductId { get; set; }
    public int? FirstProductQuantity { get; set; }
    public int? SecondTopProductId { get; set; }
    public int? SecondProductQuantity { get; set; }
    public int? ThirdTopProductId { get; set; }
    public int? ThirdProductQuantity { get; set; }
}