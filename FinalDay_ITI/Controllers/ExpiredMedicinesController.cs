using FinalDay_ITI.Repositories;

namespace FinalDay_ITI.Controllers;

public class ExpiredMedicinesController
{
    public static List<MedicineRepository> Index()
        => MedicineController.Index(medicine => medicine.ExpirationDate < DateTime.Now);

    public static List<MedicineRepository> Index(Func<MedicineRepository, bool> predicate)
        => Index().Where(predicate).ToList();
}
