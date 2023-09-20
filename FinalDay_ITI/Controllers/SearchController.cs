using FinalDay_ITI.Models;
using FinalDay_ITI.Repositories;

namespace FinalDay_ITI.Controllers;

public class SearchController
{
    public static object Index(string controllerName, object? additionalData, object? field, string value = "")
    {
        if (field == null || value == "") field = "__Index__";

        switch (controllerName)
        {
            case nameof(UserController):
                return SearchToUsers(field, value);
            case nameof(CategoryController):
                return SearchToCategories(field, value);
            case nameof(MedicineController):
                return SearchToMedicines(field, value);
            case nameof(ExpiredMedicinesController):
                return SearchToExpiredMedicines(field, value);
            case nameof(OutofStocksController):
                return SearchToOutofStocks(field, value);
            case nameof(OrderController):
                return SearchToOrders(field, value);
            case nameof(UserOrderController):
                return SearchToUserOrders(field, value);
            case nameof(OrderMedicineController):
                return SearchToOrderMedicine((Order)additionalData, field, value);
        }

        return 0;
    }

    private static object SearchToOrderMedicine(Order order, object field, string value)
    {
        return field switch
        {
            "Id" => order.Index(orderMedicine => orderMedicine.Id.ToString() == value),
            "Medicine" => order.Index(orderMedicine => orderMedicine.Medicine.ToString().Contains(value, StringComparison.OrdinalIgnoreCase)),
            "Quantity" => order.Index(orderMedicine => orderMedicine.Quantity.ToString() == value),
            "TotalPrice" => order.Index(orderMedicine => orderMedicine.TotalPrice.ToString() == value),
            "__Index__" => order.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToOutofStocks(object field, string value)
    {
        return field switch
        {
            "Id" => OutofStocksController.Index(medicine => medicine.Id.ToString() == value),
            "Medicine" => OutofStocksController.Index(medicine => medicine.Medicine.Contains(value.ToString() ?? "", StringComparison.OrdinalIgnoreCase)),
            "Category" => OutofStocksController.Index(medicine => medicine.Category.Contains(value.ToString() ?? "", StringComparison.OrdinalIgnoreCase)),
            "Price" => OutofStocksController.Index(medicine => medicine.Price.ToString() == value),
            "Quantity" => OutofStocksController.Index(medicine => medicine.Quantity.ToString() == value),
            "ProductionDate" => OutofStocksController.Index(medicine => medicine.ProductionDate.ToShortDateString().StartsWith(value)),
            "ExpirationDate" => OutofStocksController.Index(medicine => medicine.ExpirationDate.ToShortDateString().StartsWith(value)),
            "__Index__" => OutofStocksController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToOrders(object field, string value)
    {
        return field switch
        {
            "Id" => OrderController.Index((OrderRepository order) => order.Id.ToString() == value),
            "Name" => OrderController.Index((OrderRepository order) => order.Name.ToString().Contains(value, StringComparison.OrdinalIgnoreCase)),
            "Medicines" => OrderController.Index((OrderRepository order) => order.Medicines.Contains(value, StringComparison.OrdinalIgnoreCase)),
            "TotalQuantity" => OrderController.Index((OrderRepository order) => order.TotalQuantity.ToString() == value),
            "TotalPrice" => OrderController.Index((OrderRepository order) => order.TotalPrice.ToString() == value),
            "Date" => OrderController.Index((OrderRepository order) => order.Date.ToString().StartsWith(value)),
            "__Index__" => OrderController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToUserOrders(object field, string value)
    {
        return field switch
        {
            "Id" => UserOrderController.Index((OrderRepository order) => order.Id.ToString() == value),
            "Name" => UserOrderController.Index((OrderRepository order) => order.Name.ToString().Contains(value, StringComparison.OrdinalIgnoreCase)),
            "Medicines" => UserOrderController.Index((OrderRepository order) => order.Medicines.Contains(value, StringComparison.OrdinalIgnoreCase)),
            "TotalQuantity" => UserOrderController.Index((OrderRepository order) => order.TotalQuantity.ToString() == value),
            "TotalPrice" => UserOrderController.Index((OrderRepository order) => order.TotalPrice.ToString() == value),
            "Date" => UserOrderController.Index((OrderRepository order) => order.Date.ToString().StartsWith(value)),
            "__Index__" => UserOrderController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToUsers(object field, string value)
    {
        return field switch
        {
            "Id" => UserController.Index(user => user.Id.ToString() == value),
            "Name" => UserController.Index(user => user.Name.ToString().Contains(value, StringComparison.OrdinalIgnoreCase)),
            "Email" => UserController.Index(user => user.Email.ToString().Contains(value, StringComparison.OrdinalIgnoreCase)),
            "Role" => UserController.Index(user => user.Role.ToString().Contains(value, StringComparison.OrdinalIgnoreCase)),
            "OrdersNumber" => UserController.Index(user => user.Orders.Count.ToString() == value),
            "__Index__" => UserController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToMedicines(object field, string value)
    {
        return field switch
        {
            "Id" => MedicineController.Index(medicine => medicine.Id.ToString() == value),
            "Medicine" => MedicineController.Index(medicine => medicine.Name.Contains(value.ToString() ?? "", StringComparison.OrdinalIgnoreCase)),
            "Category" => MedicineController.Index(medicine => medicine.Category.Name.Contains(value.ToString() ?? "", StringComparison.OrdinalIgnoreCase)),
            "Price" => MedicineController.Index(medicine => medicine.Price.ToString() == value),
            "Quantity" => MedicineController.Index(medicine => medicine.Quantity.ToString() == value),
            "ProductionDate" => MedicineController.Index(medicine => medicine.ProductionDate.ToShortDateString().StartsWith(value)),
            "ExpirationDate" => MedicineController.Index(medicine => medicine.ExpirationDate.ToShortDateString().StartsWith(value)),
            "__Index__" => MedicineController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToExpiredMedicines(object field, string value)
    {
        return field switch
        {
            "Id" => ExpiredMedicinesController.Index(medicine => medicine.Id.ToString() == value),
            "Medicine" => ExpiredMedicinesController.Index(medicine => medicine.Medicine.Contains(value.ToString() ?? "", StringComparison.OrdinalIgnoreCase)),
            "Category" => ExpiredMedicinesController.Index(medicine => medicine.Category.Contains(value.ToString() ?? "", StringComparison.OrdinalIgnoreCase)),
            "Price" => ExpiredMedicinesController.Index(medicine => medicine.Price.ToString() == value),
            "Quantity" => ExpiredMedicinesController.Index(medicine => medicine.Quantity.ToString() == value),
            "ProductionDate" => ExpiredMedicinesController.Index(medicine => medicine.ProductionDate.ToShortDateString().StartsWith(value)),
            "ExpirationDate" => ExpiredMedicinesController.Index(medicine => medicine.ExpirationDate.ToShortDateString().StartsWith(value)),
            "__Index__" => ExpiredMedicinesController.Index(),
            _ => "Something Wrong"
        };
    }

    public static object SearchToCategories(object field, string value)
    {
        return field switch
        {
            "Id" => CategoryController.Index(category => category.Id.ToString() == value),
            "Name" => CategoryController.Index(category => category.Name.Contains(value ?? "", StringComparison.OrdinalIgnoreCase)),
            "MedicineNumber" => CategoryController.Index(category => category.Medicines.Count.ToString() == value),
            "__Index__" => CategoryController.Index(),
            _ => "Something Wrong"
        };
    }
}
