using bikerental.Domain.model;

namespace bikerental.Domain.service;
/// <summary>
/// Репозиторий для работы с клиентами.
/// </summary>
public interface ICustomerRepository : IRepository<Customer, int>
{
    /// <summary>
    /// Вывести информацию обо всех клиентах, которые брали в аренду горные велосипеды, упорядочить по ФИО.
    /// </summary>
    /// <returns>Список клиентов, арендовавших горные велосипеды.</returns>
    Task<IList<Customer>> GetCustomersWhoRentedMountainBicycles();

    /// <summary>
    /// Вывести информацию о клиентах, бравших велосипеды на прокат больше всего раз.
    /// </summary>
    /// <returns>Список кортежей с клиентами и количеством их аренды.</returns>
    Task<IList<(Customer customer, int RentalCount)>> TopCustomersByRentalCount { get; }

    /// <summary>
    /// Вывести информацию о минимальном, максимальном и среднем времени аренды велосипедов.
    /// </summary>
    /// <returns>Кортеж с минимальным, максимальным и средним временем аренды.</returns>
    Task<(TimeSpan MinRentalTime, TimeSpan MaxRentalTime, TimeSpan AvgRentalTime)> RentalTimeStatistics { get; }
}