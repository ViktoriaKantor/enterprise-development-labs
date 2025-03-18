using bikerental.Domain.Data;
using bikerental.Domain.model;

namespace bikerental.Domain.service.InMemory;
/// <summary>
/// Имплементация репозитория для велосипедов, которая хранит коллекцию в оперативной памяти
/// </summary>
public class RentalInMemoryRepository : IBicycleRepository
{
    private List<Bicycle> _bicycles;
    private List<Rental> _rentals;

    /// <summary>
    /// Конструктор репозитория
    /// </summary>
    public RentalInMemoryRepository()
    {
        _bicycles = DataSeeder.bicycles;
        _rentals = DataSeeder.rentals;
    }

    /// <inheritdoc/>
    public Task<Bicycle> Add(Bicycle entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<bool> Delete(int key)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<Bicycle?> Get(int key)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<IList<Bicycle>> GetAll()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<IList<Bicycle>> GetAllSportBicycles()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<IList<(string SerialNumber, int RentalCount)>> Top5MostRentedBicycles => throw new NotImplementedException();

    /// <summary>
    /// Получить топ 5 наиболее часто арендуемых велосипедов
    /// </summary>
    /// <returns>Список велосипедов и количества их аренды</returns>
    public Task<IList<Tuple<Bicycle, int>>> GetTop5MostRentedBicycles()
    {
        var topBicycles = _bicycles
                .GroupBy(r => r.Id)
                .Select(g => new
                {
                    BicycleId = g.Key,
                    RentalCount = g.Count()
                })
                .OrderByDescending(g => g.RentalCount)
                .Take(5)
                .Select(g =>
                {
                    Bicycle? item1 = _bicycles.FirstOrDefault(b => b.Id == g.BicycleId);
                    return new Tuple<Bicycle, int>(
                        item1: item1, g.RentalCount);
                })
                .ToList();

        return Task.FromResult<IList<Tuple<Bicycle, int>>>(topBicycles);
    }

    /// <inheritdoc/>
    public Task<IList<(Bicycle Type, TimeSpan TotalRentalTime)>> GetTotalRentalTimeByBicycleType()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<Bicycle> Update(Bicycle entity)
    {
        throw new NotImplementedException();
    }
}