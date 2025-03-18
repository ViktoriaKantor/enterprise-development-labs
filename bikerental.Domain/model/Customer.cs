using System.ComponentModel.DataAnnotations;

namespace bikerental.Domain.model
{ /// <summary>
  /// Класс для представления клиента
  /// </summary>
    public class Customer
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        [Key]
        public required int Id { get; set; }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        public required string FullName { get; set; }

        /// <summary>
        /// Год рождения клиента
        /// </summary>
        public int Birthday { get; set; }

        /// <summary>
        /// Телефон клиента
        /// </summary>
        public string? Phone { get; set; }
    }
}