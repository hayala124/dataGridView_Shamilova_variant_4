using dataGridView.Contracts;
using dataGridView.Contracts.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace dataGridView.TourManager
{
    /// <inheritdoc cref="ITourManager"/>
    public class TourManager : ITourManager
    {
        private readonly ITourStorage tourStorage;
        private readonly ILogger logger;

        /// <summary>ctor</summary>
        public TourManager(ITourStorage tourStorage, ILogger logger)
        {
            this.logger = logger;
            this.tourStorage = tourStorage;
        }

        /// <summary>
        /// Метод для добавления нового тура.
        /// </summary>
        public async Task<Tour> AddAsync(Tour tour)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = await tourStorage.AddAsync(tour);
            stopwatch.Stop();
            logger.LogInformation($"В {DateTime.Now} добавлен тур с id = {tour.Id} за {stopwatch.ElapsedMilliseconds} мс");

            return result;
        }

        /// <summary>
        /// Метод для удаления тура.
        /// </summary>
        async Task<bool> ITourManager.DeleteAsync(Guid id)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = await tourStorage.DeleteAsync(id);
            stopwatch.Stop();

            logger.LogInformation($"В {DateTime.Now} удалён тур с id = {id} за {stopwatch.ElapsedMilliseconds} мс");

            return result;
        }

        /// <summary>
        /// Метод для редактирования тура. 
        /// </summary>
        Task ITourManager.EditAsync(Tour tour)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = tourStorage.EditAsync(tour);
            stopwatch.Stop();
            logger.LogInformation($"В {DateTime.Now} изменён тур с id = {tour.Id} за {stopwatch.ElapsedMilliseconds} мс");

            return result;
        }

        /// <summary>
        /// Метод для возврата тура.
        /// </summary>
        Task<IReadOnlyCollection<Tour>> ITourManager.GetAllAsync() => tourStorage.GetAllAsync();

        /// <summary>
        /// Метод для возврата статистики о турах.
        /// </summary>
        async Task<ITourStats> ITourManager.GetStatsAsync()
        {
            var result = await tourStorage.GetAllAsync();

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
