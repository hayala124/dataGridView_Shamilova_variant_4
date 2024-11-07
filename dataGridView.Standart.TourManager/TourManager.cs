using dataGridView.Standart.Contracts;
using dataGridView.Standart.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dataGridView.Standart.TourManager
{
    public class TourManager: ITourManager
    {
        private ITourStorage tourStorage;

        /// <summary>
        /// Принимает объект tourStorage и сохраняет его в поле tourStorage.
        /// </summary>
        public TourManager(ITourStorage tourStorage)
        {
            this.tourStorage = tourStorage;
        }

        /// <summary>
        /// Метод для добавления нового тура.
        /// </summary>
        public async Task<Tour> AddAsync(Tour tour)
        {
            var result = await tourStorage.AddAsync(tour);
            tour.TotalCost = tour.CostVacationer * tour.NumberOfVacationer + tour.Surcharges;
            
            return result;
        }

        /// <summary>
        /// Метод для удаления тура.
        /// </summary>
        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await tourStorage.DeleteAsync(id);
            return result;
        }

        /// <summary>
        /// Метод для редактирования тура. 
        /// </summary>
        public Task EditAsync(Tour tour) => tourStorage.EditAsync(tour);

        /// <summary>
        /// Метод для возврата тура.
        /// </summary>
        public Task<IReadOnlyCollection<Tour>> GetAllAsync() => tourStorage.GetAllAsync();

        /// <summary>
        /// Метод для возврата статистики о турах.
        /// </summary>
        public async Task<ITourStats> GetStatsAsync()
        {
            var result = await tourStorage.GetAllAsync();

            //new
            foreach (var tour in result)
            {
                tour.TotalCost = tour.CostVacationer * tour.NumberOfVacationer + tour.Surcharges;
            }

            return new TourStatsModel
            {
                TotalCountTours = result.Count,
                TotalCostTours = result.DefaultIfEmpty(new Tour()).Sum(x => x.TotalCost),
                CountToursWithSurcharges = result.Where(x => x.Surcharges > 0).Count(),
                TotalCostOfSurcharges = result.DefaultIfEmpty(new Tour()).Sum(x => x.Surcharges),
            };
        }
    }
}
