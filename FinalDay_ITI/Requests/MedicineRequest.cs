using FinalDay_ITI.Models;

namespace FinalDay_ITI.Requests;

public class MedicineRequest
{
    private string _name;
    private double _price;
    private int _quantity;
    private DateTime _productionDate;
    private DateTime _expirationDate;
    public int _categoryId;

    public MedicineRequest(string name, double price, int quantity, DateTime productionDate, DateTime expirationDate, int categoryId)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _productionDate = productionDate;
        _expirationDate = expirationDate;
        _categoryId = categoryId;
    }

    public Medicine Validate()
    {
        _name = _name.Trim();

        if (_name.IsEmpty())
            throw new("Fill all fields please.");

        if (!_name.Min(3)) throw new("Name is too small.");

        return new()
        {
            Name = _name,
            Price = _price,
            Quantity = _quantity,
            ProductionDate = _productionDate,
            ExpirationDate = _expirationDate,
            CategoryId = _categoryId,
        };
    }
}
