using dataGridView.Framework.Contracts.Models;

namespace dataGridView.Framework.TourManager.Models
{
    /// <summary>
    /// Модель, содержащая статические данные о турах.
    /// </summary>
    public class TourStatsModel : ITourStats
    {
        /// <summary>
        /// Общее количество туров.
        /// </summary>
        public decimal TotalCountTours { get; set; }

        /// <summary>
        /// Общая сумма за все туры.
        /// </summary>
        public decimal TotalCostTours { get; set; }

        /// <summary>
        /// Количество туров с доплатами.
        /// </summary>
        public decimal CountToursWithSurcharges { get; set; }

        /// <summary>
        /// Общая сумма доплат.
        /// </summary>
        public decimal TotalCostOfSurcharges { get; set; }
    }
}
