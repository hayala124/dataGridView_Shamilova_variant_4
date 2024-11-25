using System;
using dataGridView.Contracts.Models;
using dataGridView.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace dataGridView.Storage.DataBase
{
    public class DataBaseTourStorage : ITourStorage
    {
        /// <inheritdoc cref="ITourStorage"/>
        public async Task<Tour> AddAsync(Tour tour)
        {
            using (var context = new ToursContext())
            {
                context.Tours.Add(tour);
                await context.SaveChangesAsync();
            }

            return tour;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            using (var context = new ToursContext())
            {
                var item = await context.Tours.FirstOrDefaultAsync(x => x.Id == id);
                if (item != null)
                {
                    context.Tours.Remove(item);
                    await context.SaveChangesAsync();
                    return true;
                }
            }

            return false;
        }

        public async Task EditAsync(Tour tour)
        {
            using (var context = new ToursContext())
            {
                var target = await context.Tours.FirstOrDefaultAsync(x => x.Id == tour.Id);
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

                await context.SaveChangesAsync();
            }
        }

        public async Task<IReadOnlyCollection<Tour>> GetAllAsync()
        {
            using (var context = new ToursContext())
            {
                var items = await context.Tours
                    .OrderBy(x => x.Direction)
                    .ThenByDescending(x => x.DepartureDate)
                    .ToListAsync();

                return items;
            }
        }
    }
}
