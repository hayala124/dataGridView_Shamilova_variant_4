using dataGridView.Contracts.Models;
using System.Data.Entity;

namespace dataGridView.Storage.DataBase
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public class ToursContext : DbContext
    {
        /// <summary>ctor</summary>
        public ToursContext():base("TourDBConnectionString")
        {

        }

        /// <summary>
        /// Таблица <see cref="Tour"/> в БД
        /// </summary>
        public DbSet<Tour> Tours { get; set; }

    }
}
