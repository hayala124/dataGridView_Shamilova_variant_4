using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dataGridView.Framework.Contracts.Models;

namespace dataGridView.Framework.Contracts
{
    /// <summary>
    /// Интерфейс для управления турами.
    /// </summary>
    public interface ITourManager
    {
        Task<IReadOnlyCollection<Tour>> GetAllAsync();

        Task<Tour> AddAsync(Tour tour);

        Task EditAsync(Tour tour);

        Task<bool> DeleteAsync(Guid id);

        Task<ITourStats> GetStatsAsync();
    }
}
