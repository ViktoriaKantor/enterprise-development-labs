using bikerental.Domain.Data;
using System.Xml.Linq;
using bikerental.Domain.model;

namespace bikerental.Domain.service.InMemory;
/// <summary>
/// Имплементация репозитория для авторов, которая хранит коллекцию в оперативной памяти 
/// </summary>
public class BicycleInMemoryRepository : IRepository<Bicycle, int>
{
    private List<Bicycle> bicycles;

    /// <summary>
    /// Конструктор репозитория
    /// </summary>
    public BicycleInMemoryRepository() => bicycles = DataSeeder.bicycles;

    /// <inheritdoc/>
    public Task<Bicycle> Add(Bicycle entity)
    {
        try
        {
            bicycles.Add(entity);
        }
        catch
        {
            return null!;
        }
        return Task.FromResult(entity);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(int key)
    {
        try
        {
            var bicycle = await Get(key);
            if (bicycle != null)
                bicycles.Remove(bicycle);
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <inheritdoc/>
    public Task<Bicycle?> Get(int key) =>
        Task.FromResult(bicycles.FirstOrDefault(item => item.Id == key));

    /// <inheritdoc/>
    public Task<IList<Bicycle>> GetAll() =>
        Task.FromResult((IList<Bicycle>)bicycles);

    /// <inheritdoc/>
    public async Task<Bicycle> Update(Bicycle entity)
    {
        try
        {
            await Delete(entity.Id);
            await Add(entity);
        }
        catch
        {
            return null!;
        }
        return entity;
    }
}