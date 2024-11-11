using System;
using System.Collections.Generic;
using dataGridView.Contracts;
using dataGridView.Contracts.Models;
using System.Linq;
using System.Threading.Tasks;

namespace dataGridView.TourStorage
{
    /// <inheritdoc cref="ITourStorage"/>
    public class TourStorage : ITourStorage
    {
        private List<Tour> tours;

        /// <summary>ctor</summary>
        public TourStorage()
        {
            tours = new List<Tour>();
        }

        Task<Tour> ITourStorage.AddAsync(Tour tour)
        {
            tours.Add(tour);
            return Task.FromResult(tour);
        }

        Task<bool> ITourStorage.DeleteAsync(Guid id)
        {
            var tour = tours.FirstOrDefault(x => x.Id == id);
            if (tour != null)
            {
                tours.Remove(tour);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        Task ITourStorage.EditAsync(Tour tour)
        {
            var target = tours.FirstOrDefault(x => x.Id == tour.Id);
            if (target != null)
            {
                target.Direction = tour.Direction;
                target.DepartureDate = tour.DepartureDate;
                target.NumberOfNights = tour.NumberOfNights;
                target.CostVacationer = tour.CostVacationer;
                target.NumberOfVacationer = tour.NumberOfVacationer;
                target.WiFi = tour.WiFi;
                target.Surcharges = tour.Surcharges;
            }

            return Task.CompletedTask;
        }

        Task<IReadOnlyCollection<Tour>> ITourStorage.GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Tour>>(tours);

    }
}
