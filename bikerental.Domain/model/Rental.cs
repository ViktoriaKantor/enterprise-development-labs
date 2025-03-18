using System.ComponentModel.DataAnnotations;

namespace bikerental.Domain.model
{
    /// <summary>
    /// Аренда велосипеда
    /// </summary>
    public class Rental
    {
        /// <summary>
        /// Идентификатор аренды
        /// </summary>
        [Key]
        public required int Id { get; set; }

        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public required int CustomerId { get; set; }

        /// <summary>
        /// Идентификатор велосипеда
        /// </summary>
        public required int BicycleId { get; set; }

        /// <summary>
        /// Время начала аренды
        /// </summary>
        public required DateTime StartTime { get; set; }

        /// <summary>
        /// Время окончания аренды
        /// </summary>
        public required DateTime EndTime { get; set; }

        /// <summary>
        /// Перегрузка метода, возвращающего строковое представление объекта
        /// </summary>
        /// <returns>Информация об аренде</returns>
        public override string ToString() =>
            $"Аренда {BicycleId} для клиента {CustomerId} с {StartTime} по {EndTime}";
    }
}