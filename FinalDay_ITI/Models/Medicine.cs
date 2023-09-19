namespace FinalDay_ITI.Models;

public class Medicine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public DateTime ProductionDate { get; set; }
    public DateTime ExpirationDate { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }

    public virtual ICollection<OrderMedicine> OrderMedicines { get; set; }
}
