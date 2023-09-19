namespace FinalDay_ITI.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Medicine> Medicines { get; set; }
}
