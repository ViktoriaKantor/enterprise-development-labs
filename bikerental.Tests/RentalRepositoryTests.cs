using Xunit;
using bikerental.Domain.service.InMemory;
namespace bikerental.Tests;

/// <summary>
/// Класс с юнит-тестами репозитория велосипедов
/// </summary>
public class RentalInMemoryRepositoryTests
{

    private readonly RentalInMemoryRepository _repository;

    public RentalInMemoryRepositoryTests()
    {
        _repository = new RentalInMemoryRepository();
    }

    /// <summary>
    /// Тест метода, возвращающего топ 5 наиболее часто арендуемых велосипедов
    /// </summary>
    [Fact]
    public async Task GetTop5MostRentedBicycles_Success()
    {
        var repo = new BicycleInMemoryRepository();
        var topBicycle = await _repository.GetTop5MostRentedBicycles();

        Assert.Equal(4, topBicycle.Count);
    }
}