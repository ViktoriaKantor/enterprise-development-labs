using bikerental.Domain.model;

namespace bikerental.Domain.Data
{
    /// <summary>
    /// Класс для заполнения коллекций данными
    /// </summary>
    public static class DataSeeder
    {
        /// <summary>
        /// Коллекция велосипедов, использующаяся для первичного наполнения базы данных 
        /// </summary>
        public static readonly List<Bicycle> bicycles =
            new()
            {
                new() { Id = 1, SerialNumber = "SN001", Type = "Sport", Model = "Model A", Color = "Red"},
                new() { Id = 2, SerialNumber = "SN002", Type = "Mountain", Model = "Model B", Color = "Blue" },
                new() { Id = 3, SerialNumber = "SN003", Type = "Sport", Model = "Model C", Color = "Green"},
                new() { Id = 4, SerialNumber = "SN004", Type = "Leisure", Model = "Model D", Color = "Yellow"},
            };

        /// <summary>
        /// Коллекция клиентов, использующаяся для первичного наполнения базы данных 
        /// </summary>
        public static readonly List<Customer> customers =
            new()
            {
                new() { Id = 1, FullName = "Иванов Иван Иванович", Birthday = 1990, Phone = "123-456-7890" },
                new() { Id = 2, FullName = "Петров Петр Петрович", Birthday = 1985, Phone = "098-765-4321" },
                new() { Id = 3, FullName = "Сидоров Сидор Сидорович", Birthday = 1992, Phone = "555-555-5555" },
            };

        /// <summary>
        /// Коллекция аренды, использующаяся для первичного наполнения базы данных 
        /// </summary>
        public static readonly List<Rental> rentals =
            new()
            {
                new() { Id = 1, CustomerId = 1, BicycleId = 1, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2) },
                new() { Id = 2, CustomerId = 2, BicycleId = 3, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1) },
                new() { Id = 3, CustomerId = 1, BicycleId = 2, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(3) },
            };
    }
}