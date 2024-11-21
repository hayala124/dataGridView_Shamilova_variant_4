using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dataGridView.Contracts.Models;

namespace dataGridView.Contracts
{
    /// <summary>
    /// Управление турами.
    /// </summary>
    public interface ITourManager
    {
        /// <summary>
        /// Получение данных из коллекции.
        /// </summary>
        Task<IReadOnlyCollection<Tour>> GetAllAsync();

        /// <summary>
        /// Добавление данных в коллекцию.
        /// </summary>
        Task<Tour> AddAsync(Tour tour);

        /// <summary>
        /// Редактирование данных из коллекции.
        /// </summary>
        Task EditAsync(Tour tour);

        /// <summary>
        /// Удаление данных из коллекции.
        /// </summary>
        Task<bool> DeleteAsync(Guid id);

        /// <summary>
        /// Получение статистики.
        /// </summary>
        Task<ITourStats> GetStatsAsync();
    }
}
