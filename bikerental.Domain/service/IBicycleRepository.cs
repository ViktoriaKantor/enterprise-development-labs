using bikerental.Domain.model;

namespace bikerental.Domain.service;
/// <summary>
/// Репозиторий для работы с велосипедами.
/// </summary>
public interface IBicycleRepository : IRepository<Bicycle, int>
{
    /// <summary>
    /// Вывести информацию обо всех спортивных велосипедах.
    /// </summary>
    /// <returns>Список спортивных велосипедов.</returns>
    Task<IList<Bicycle>> GetAllSportBicycles();

    /// <summary>
    /// Вывести информацию о топ 5 наиболее часто арендуемых велосипедах.
    /// </summary>
    /// <returns>Список кортежей с серийным номером велосипеда и количеством аренды.</returns>
    Task<IList<(string SerialNumber, int RentalCount)>> Top5MostRentedBicycles { get; }

    /// <summary>
    /// Вывести суммарное время аренды велосипедов каждого типа.
    /// </summary>
    /// <returns>Список кортежей с типом велосипеда и суммарным временем аренды.</returns>
    Task<IList<(Bicycle Type, TimeSpan TotalRentalTime)>> GetTotalRentalTimeByBicycleType();
}
