using FinalDay_ITI.Models;
using FinalDay_ITI.Repositories;

namespace FinalDay_ITI.Controllers;

public class SearchController
{
    public static object Index(string controllerName, object additionalData, object? field, string value = "")
    {
        if (field == null || value == "") field = "__Index__";

        return controllerName switch
        {
            nameof(UserController) => SearchToUsers(field, value),
            nameof(CategoryController) => SearchToCategories(field, value),
            nameof(MedicineController) => SearchToMedicines(field, value),
            nameof(ExpiredMedicinesController) => SearchToExpiredMedicines(field, value),
            nameof(OutOfStocksController) => SearchToOutOfStocks(field, value),
            nameof(OrderController) => SearchToOrders(field, value),
            nameof(UserOrderController) => SearchToUserOrders(field, value),
            nameof(OrderMedicineController) => SearchToOrderMedicine((Order)(additionalData), field, value),
            _ => 0,
        };
    }

    private static object SearchToOrderMedicine(Order order, object field, string value)
    {
        return field switch
        {
            "Id" => order.Index(orderMedicine => orderMedicine.Id.Comparison(value)),
            "Medicine" => order.Index(orderMedicine => orderMedicine.Medicine.Comparison(value)),
            "Quantity" => order.Index(orderMedicine => orderMedicine.Quantity.Comparison(value)),
            "TotalPrice" => order.Index(orderMedicine => orderMedicine.TotalPrice.Comparison(value)),
            "__Index__" => order.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToOutOfStocks(object field, string value)
    {
        return field switch
        {
            "Id" => OutOfStocksController.Index(medicine => medicine.Id.Comparison(value)),
            "Medicine" => OutOfStocksController.Index(medicine => medicine.Medicine.Comparison(value)),
            "Category" => OutOfStocksController.Index(medicine => medicine.Category.Comparison(value)),
            "Price" => OutOfStocksController.Index(medicine => medicine.Price.Comparison(value)),
            "Quantity" => OutOfStocksController.Index(medicine => medicine.Quantity.Comparison(value)),
            "ProductionDate" => OutOfStocksController.Index(medicine => medicine.ProductionDate.Comparison(value)),
            "ExpirationDate" => OutOfStocksController.Index(medicine => medicine.ExpirationDate.Comparison(value)),
            "__Index__" => OutOfStocksController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToOrders(object field, string value)
    {
        return field switch
        {
            "Id" => OrderController.Index((OrderRepository order) => order.Id.Comparison(value)),
            "User" => OrderController.Index((OrderRepository order) => order.User.Comparison(value)),
            "Medicines" => OrderController.Index((OrderRepository order) => order.Medicines.Comparison(value)),
            "TotalQuantity" => OrderController.Index((OrderRepository order) => order.TotalQuantity.Comparison(value)),
            "TotalPrice" => OrderController.Index((OrderRepository order) => order.TotalPrice.Comparison(value)),
            "Date" => OrderController.Index((OrderRepository order) => order.Date.Comparison(value)),
            "__Index__" => OrderController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToUserOrders(object field, string value)
    {
        return field switch
        {
            "Id" => UserOrderController.Index((OrderRepository order) => order.Id.Comparison(value)),
            "User" => UserOrderController.Index((OrderRepository order) => order.User.Comparison(value)),
            "Medicines" => UserOrderController.Index((OrderRepository order) => order.Medicines.Comparison(value)),
            "TotalQuantity" => UserOrderController.Index((OrderRepository order) => order.TotalQuantity.Comparison(value)),
            "TotalPrice" => UserOrderController.Index((OrderRepository order) => order.TotalPrice.Comparison(value)),
            "Date" => UserOrderController.Index((OrderRepository order) => order.Date.Comparison(value)),
            "__Index__" => UserOrderController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToUsers(object field, string value)
    {
        return field switch
        {
            "Id" => UserController.Index(user => user.Id.Comparison(value)),
            "Name" => UserController.Index(user => user.Name.Comparison(value)),
            "Email" => UserController.Index(user => user.Email.Comparison(value)),
            "Role" => UserController.Index(user => user.Role.Comparison(value)),
            "OrdersNumber" => UserController.Index(user => user.Orders.Comparison(value)),
            "__Index__" => UserController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToMedicines(object field, string value)
    {
        return field switch
        {
            "Id" => MedicineController.Index(medicine => medicine.Id.Comparison(value)),
            "Medicine" => MedicineController.Index(medicine => medicine.Name.Comparison(value)),
            "Category" => MedicineController.Index(medicine => medicine.Category.Name.Comparison(value)),
            "Price" => MedicineController.Index(medicine => medicine.Price.Comparison(value)),
            "Quantity" => MedicineController.Index(medicine => medicine.Quantity.Comparison(value)),
            "ProductionDate" => MedicineController.Index(medicine => medicine.ProductionDate.Comparison(value)),
            "ExpirationDate" => MedicineController.Index(medicine => medicine.ExpirationDate.Comparison(value)),
            "__Index__" => MedicineController.Index(),
            _ => "Something Wrong"
        };
    }

    private static object SearchToExpiredMedicines(object field, string value)
    {
        return field switch
        {
            "Id" => ExpiredMedicinesController.Index(medicine => medicine.Id.Comparison(value)),
            "Medicine" => ExpiredMedicinesController.Index(medicine => medicine.Medicine.Comparison(value)),
            "Category" => ExpiredMedicinesController.Index(medicine => medicine.Category.Comparison(value)),
            "Price" => ExpiredMedicinesController.Index(medicine => medicine.Price.Comparison(value)),
            "Quantity" => ExpiredMedicinesController.Index(medicine => medicine.Quantity.Comparison(value)),
            "ProductionDate" => ExpiredMedicinesController.Index(medicine => medicine.ProductionDate.Comparison(value)),
            "ExpirationDate" => ExpiredMedicinesController.Index(medicine => medicine.ExpirationDate.Comparison(value)),
            "__Index__" => ExpiredMedicinesController.Index(),
            _ => "Something Wrong"
        };
    }

    public static object SearchToCategories(object field, string value)
    {
        return field switch
        {
            "Id" => CategoryController.Index(category => category.Id.Comparison(value)),
            "Name" => CategoryController.Index(category => category.Name.Comparison(value)),
            "MedicineNumber" => CategoryController.Index(category => category.Medicines.Comparison(value)),
            "__Index__" => CategoryController.Index(),
            _ => "Something Wrong"
        };
    }
}

static class Search
{
    public static bool Comparison(this int number, string value) => number.ToString() == value;
    public static bool Comparison(this double number, string value) => number.ToString() == value;
    public static bool Comparison(this string text, string value) => text.Contains(value, StringComparison.OrdinalIgnoreCase);
    public static bool Comparison(this DateOnly date, string value) => date.ToShortDateString().StartsWith(value);
    public static bool Comparison(this DateTime date, string value) => date.ToShortDateString().StartsWith(value);
    public static bool Comparison(this Enum @enum, string value) => @enum.ToString().Comparison(value);
    public static bool Comparison<T>(this ICollection<T> collection, string value) => collection.Count.Comparison(value);
}
