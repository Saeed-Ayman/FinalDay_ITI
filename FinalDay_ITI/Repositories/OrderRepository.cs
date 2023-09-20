namespace FinalDay_ITI.Repositories;

public class OrderRepository
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Medicines { get; set; }
    public int TotalQuantity { get; set; }
    public double TotalPrice { get; set; }
    public DateTime Date { get; set; }
}
