using dataGridView.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dataGridView.Contracts
{
    /// <summary>
    /// Хранение и управление турами.
    /// </summary>
    public interface ITourStorage
    {
        Task<IReadOnlyCollection<Tour>> GetAllAsync();

        Task<Tour> AddAsync(Tour tour);

        Task EditAsync(Tour tour);

        Task<bool> DeleteAsync(Guid id);
    }
}
