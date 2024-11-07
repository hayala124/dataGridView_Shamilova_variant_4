using System;

namespace dataGridView.Standart.Contracts.Models
{
    /// <summary>
    /// Туры.
    /// </summary>
    public class Tour
    {
        public Guid Id { get; set; }

        /// <inheritdoc cref="Models.Direction"
        public Direction Direction { get; set; }

        /// <summary>
        /// Дата вылета.
        /// </summary>    
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// Количество ночей.
        /// </summary>  
        public decimal NumberOfNights { get; set; }

        /// <summary>
        /// Стоимость за отдыхающего (руб).
        /// </summary>
        public decimal CostVacationer { get; set; }

        /// <summary>
        /// Количество отдыхающих.
        /// </summary>
        public decimal NumberOfVacationer { get; set; }

        /// <summary>
        /// Наличие WiFi.
        /// </summary>  
        public bool WiFi { get; set; }

        /// <summary>
        /// Доплаты (руб).
        /// </summary>   
        public decimal Surcharges { get; set; }

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        public decimal TotalCost { get; set; }
    }
}