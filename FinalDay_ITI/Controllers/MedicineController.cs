using FinalDay_ITI.Models;
using FinalDay_ITI.Views.Medicine;
using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Controllers;

class MedicineController
{
    private static readonly PharmacyContext _db = MainController.DB;

    public static object Index()
    {
        return _db.Medicines.Include("OrderMedicines").Select(medicine => new
        {
            medicine.Id,
            medicine.Name,
            medicine.Price,
            medicine.Quantity,
            ProductionDate = new DateOnly(medicine.ProductionDate.Year, medicine.ProductionDate.Month, medicine.ProductionDate.Day),
            ExpirationDate = new DateOnly(medicine.ExpirationDate.Year, medicine.ExpirationDate.Month, medicine.ExpirationDate.Day),
            SoldNumbers = medicine.OrderMedicines.Count,
            Category = medicine.Category.Name,
        }).ToList();
    }

    public static void Create(Form parent)
    {
        new AddMedicine().ShowDialog(parent);
    }

    public static void Store(string name, double price, int quantity, DateTime productionDate, DateTime expirationDate, int categoryId)
    {
        // TODO : Make Validation
        _db.Medicines.Add(new()
        {
            Name = name,
            Price = price,
            Quantity = quantity,
            ProductionDate = productionDate,
            ExpirationDate = expirationDate,
            CategoryId = categoryId,
        });

        _db.SaveChanges();
    }

    public static void Edit(int id, Form parent)
    {
        var Medicine = _db.Medicines.Where(Medicine => id == Medicine.Id).ToList().Single();

        new EditMedicine(Medicine).ShowDialog(parent);
    }

    public static void Update(int id, string name, double price, int quantity, DateTime productionDate, DateTime expirationDate, int categoryId)
    {
        var Medicine = _db.Medicines.Where(Medicine => id == Medicine.Id).ToList().Single();

        Medicine.Name = name;
        Medicine.Price = price;
        Medicine.Quantity = quantity;
        Medicine.ProductionDate = productionDate;
        Medicine.ExpirationDate = expirationDate;
        Medicine.CategoryId = categoryId;

        _db.SaveChanges();
    }

    public static void Destroy(int id)
    {
        var Medicine = _db.Medicines.Where(Medicine => id == Medicine.Id).ToList().Single();

        _db.Medicines.Remove(Medicine);

        _db.SaveChanges();
    }
}
