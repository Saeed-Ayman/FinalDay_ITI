using FinalDay_ITI.Models;
using FinalDay_ITI.Requests;
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
            Category = medicine.Category.Name,
            medicine.Price,
            medicine.Quantity,
            ProductionDate = new DateOnly(medicine.ProductionDate.Year, medicine.ProductionDate.Month, medicine.ProductionDate.Day),
            ExpirationDate = new DateOnly(medicine.ExpirationDate.Year, medicine.ExpirationDate.Month, medicine.ExpirationDate.Day),
        }).ToList();
    }

    public static void Create(Form parent)
    {
        new AddMedicine().ShowDialog(parent);
    }

    public static void Store(MedicineRequest request)
    {
        var medicine = request.Validate();

        _db.Medicines.Add(medicine);

        _db.SaveChanges();
    }

    public static void Edit(int id, Form parent)
    {
        var Medicine = _db.Medicines.Where(Medicine => id == Medicine.Id).ToList().Single();

        new EditMedicine(Medicine).ShowDialog(parent);
    }

    public static void Update(int id, MedicineRequest request)
    {
        var editedMedicine = request.Validate();

        var medicine = _db.Medicines.Where(medicine => medicine.Id == id).ToList().Single();

        medicine.Name = editedMedicine.Name;
        medicine.Price = editedMedicine.Price;
        medicine.Quantity = editedMedicine.Quantity;
        medicine.ProductionDate = editedMedicine.ProductionDate;
        medicine.ExpirationDate = editedMedicine.ExpirationDate;
        medicine.CategoryId = editedMedicine.CategoryId;

        _db.SaveChanges();
    }

    public static void Delete(int id, Form parent)
        => new DeleteMedicine(_db.Medicines.Include("Category").Where(medicine => id == medicine.Id).ToList().Single()).ShowDialog(parent);

    public static void Destroy(int id)
    {
        var Medicine = _db.Medicines.Where(Medicine => id == Medicine.Id).ToList().Single();

        _db.Medicines.Remove(Medicine);

        _db.SaveChanges();
    }
}
