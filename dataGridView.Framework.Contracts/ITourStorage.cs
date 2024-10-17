using dataGridView.Framework.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dataGridView.Framework.Contracts
{
    /// <summary>
    /// Интерфейс для хранения и управления турами.
    /// </summary>
    public interface ITourStorage
    {
        Task<IReadOnlyCollection<Tour>> GetAllAsync();

        Task<Tour> AddAsync(Tour tour);

        Task EditAsync(Tour tour);

        Task<bool> DeleteAsync(Guid id);
    }
}
