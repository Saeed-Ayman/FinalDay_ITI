namespace FinalDay_ITI.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }

    public virtual ICollection<OrderMedicine> OrderMedicines { get; set; }
}
