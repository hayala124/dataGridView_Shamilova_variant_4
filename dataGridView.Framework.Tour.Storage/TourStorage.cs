using System;
using System.Collections.Generic;
using dataGridView.Framework.Contracts;
using dataGridView.Framework.Contracts.Models;
using System.Linq;
using System.Threading.Tasks;

namespace dataGridView.Framework.TourStorage
{
    public class TourStorage : ITourStorage
    {
        private List<Tour> tours;

        public TourStorage()
        {
            tours = new List<Tour>();
        }

        public Task<Tour> AddAsync(Tour tour)
        {
            tours.Add(tour);
            return Task.FromResult(tour);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            var tour = tours.FirstOrDefault(x => x.Id == id);
            if (tour != null)
            {
                tours.Remove(tour);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task EditAsync(Tour tour)
        {
            var target = tours.FirstOrDefault(x => x.Id == tour.Id);
            if (tour != null)
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

        public Task<IReadOnlyCollection<Tour>> GetAllAsync()
            => Task.FromResult<IReadOnlyCollection<Tour>>(tours);

    }
}
