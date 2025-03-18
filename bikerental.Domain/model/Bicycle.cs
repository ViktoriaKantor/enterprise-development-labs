using System.ComponentModel.DataAnnotations;

namespace bikerental.Domain.model
{
    /// <summary>
    /// Велосипед
    /// </summary>
    public class Bicycle
    {
        /// <summary>
        /// Идентификатор велосипеда
        /// </summary>
        [Key]
        public required int Id { get; set; }

        /// <summary>
        /// Серийный номер велосипеда
        /// </summary>
        public required string SerialNumber { get; set; }

        /// <summary>
        /// Тип велосипеда (горный, прогулочный, спортивный)
        /// </summary>
        public required string Type { get; set; } // Например: "Mountain", "Leisure", "Sport"

        /// <summary>
        /// Модель велосипеда
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// Цвет велосипеда
        /// </summary>
        public string? Color { get; set; }

        internal static Bicycle FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Перегрузка метода, возвращающего строковое представление объекта
        /// </summary>
        /// <returns>Информация о велосипеде</returns>
        public override string ToString() => $"{Model ?? "<Без модели>"} ({Type}) - {Color ?? "<Без цвета>"}";
    }
}
