namespace FinalDay_ITI.Models;

public class OrderMedicine
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int OrderId { get; set; }
    public virtual Order Order { get; set; }

    public int MedicineId { get; set; }
    public virtual Medicine Medicine { get; set; }
}
