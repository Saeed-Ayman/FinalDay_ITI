using FinalDay_ITI.Models;
using FinalDay_ITI.Views.Category;
using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Controllers;

class CategoryController
{
    private static readonly PharmacyContext _db = MainController.DB;

    public static object Index()
    {
        return _db.Categories.Include("Medicines").Select(category => new
        {
            category.Id,
            category.Name,
            MedicineNumber = category.Medicines.Count
        }).ToList();
    }

    public static void Create(Form parent)
    {
        new AddCategory().ShowDialog(parent);
    }

    public static void Store(string name)
    {
        if (_db.Categories.Where(category => category.Name == name).Any())
            throw new("Category is already exists.");

        _db.Categories.Add(new() { Name = name });

        _db.SaveChanges();
    }

    public static void Edit(int id, Form parent)
    {
        var category = _db.Categories.Where(category => category.Id == id).ToList().Single();

        new EditCategory(category).ShowDialog(parent);
    }

    public static void Update(int id, string name)
    {
        if (_db.Categories.Where(category => category.Name == name).Any())
            throw new("Category is already exists.");

        var category = _db.Categories.Where(category => id == category.Id).ToList().Single();

        category.Name = name;

        _db.SaveChanges();
    }

    public static void Destroy(int id)
    {
        var category = _db.Categories.Where(category => id == category.Id).ToList().Single();

        _db.Categories.Remove(category);

        _db.SaveChanges();
    }

    public static void Delete(int id, Form form)
        => new DeleteCategory(_db.Categories.Where(category => id == category.Id).ToList().Single()).ShowDialog(form);
}
