namespace FinalDay_ITI.Repositories;

public class MedicineRepository
{
    public int Id { get; set; }
    public string Medicine { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public DateOnly ProductionDate { get; set; }
    public DateOnly ExpirationDate { get; set; }
}
