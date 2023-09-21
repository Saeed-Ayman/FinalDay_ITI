using FinalDay_ITI.Repositories;

namespace FinalDay_ITI.Controllers;

public class OutOfStocksController
{
    public static List<MedicineRepository> Index()
        => MedicineController.Index(medicine => medicine.Quantity == 0);

    public static List<MedicineRepository> Index(Func<MedicineRepository, bool> predicate)
        => Index().Where(predicate).ToList();
}
