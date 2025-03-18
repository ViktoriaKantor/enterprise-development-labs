using Xunit;
using bikerental.Domain.service.InMemory;
namespace bikerental.Tests
{
    /// <summary>
    /// Класс с юнит-тестами репозитория велосипедов
    /// </summary>
    public class RentalInMemoryRepositoryTests
    {

        private readonly RentalInMemoryRepository _repository;

        public RentalInMemoryRepositoryTests()
        {
            // Инициализация репозитория с данными из DataSeeder
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

            Assert.NotNull(topBicycle);
            Assert.True(topBicycle.Count <= 5); // Проверяем, что количество не превышает 5
        }

        private async Task<object?> GetTop5MostRentedBicycles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Тест метода, проверяющего, что возвращаемые велосипеды не равны null
        /// </summary>
        [Fact]
        public async Task GetTop5MostRentedBicycles_ValidData()
        {
            var repo = new BicycleInMemoryRepository();
            var topBicycle = await repo.GetTop5MostRentedBicycles();

            // Проверяем, что все велосипеды в топе не равны null и имеют корректные данные
            foreach (var tuple in topBicycle)
            {
                Assert.NotNull(tuple.Item1); // Проверяем, что велосипед не null
                Assert.True(tuple.Item2 > 0); // Проверяем, что количество аренды больше 0
            }
        }

        /// <summary>
        /// Тест метода, проверяющего, что возвращаемый велосипед имеет корректные данные
        /// </summary>
        [Fact]
        public async Task GetBicycleWithRentals_Success()
        {
            var repo = new BicycleInMemoryRepository();
            var bicycleWithRentals = await repo.GetBicycleWithRentals(1); // Предполагаем, что 1 - это ID велосипеда

            Assert.NotNull(bicycleWithRentals);
            Assert.NotNull(bicycleWithRentals.Item1); // Проверяем, что велосипед не null
            Assert.NotNull(bicycleWithRentals.Item2); // Проверяем, что количество аренды не null
        }
    }
}