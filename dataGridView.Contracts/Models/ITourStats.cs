namespace dataGridView.Contracts.Models
{
    /// <summary>
    /// Интерфейс для получения статистики по турам.
    /// </summary>
    public interface ITourStats
    {
        decimal TotalCountTours { get; }

        decimal TotalCostTours { get; }

        decimal CountToursWithSurcharges { get; }

        decimal TotalCostOfSurcharges { get; }
    }
}
