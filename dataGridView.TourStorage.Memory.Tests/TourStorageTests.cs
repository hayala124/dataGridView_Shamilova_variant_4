using dataGridView.Contracts.Models;
using dataGridView.Contracts;
using dataGridView_Shamilova_variant_4.Bindings;
using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Linq;

namespace dataGridView.TourStorage.Memory.Tests
{
    /// <summary>
    /// Тесты для <see cref="TourStorage"/>
    /// </summary>
    public class TourStorageTests
    {
        private readonly ITourStorage tourStorage;

        /// <summary>ctor</summary>
        public TourStorageTests()
        {
            tourStorage = new TourStorage();
        }

        /// <summary>
        /// Добавление тура.
        /// </summary>
        [Fact]
        public async Task AddShouldReturnValue()
        {
            // Arrange
            var model = DateGenerate.CreateTour();

            // Act
            var result = await tourStorage.AddAsync(model);

            // Assert
            result.Should().NotBeNull().And.BeEquivalentTo(new
            {
                model.Id,
                model.Direction,
                model.DepartureDate,
                model.NumberOfNights,
                model.CostVacationer,
                model.NumberOfVacationer,
                model.WiFi,
                model.Surcharges,
                model.TotalCost,
            });
        }


        /// <summary>
        /// Изменение тура.
        /// </summary>
        [Fact]
        public async Task EditShouldUpdateExistingTour()
        {
            // Arrange
            var model = new Tour
            {
                Id = Guid.NewGuid(),
                Direction = Direction.Italy,
                DepartureDate = DateTime.Now.AddDays(50),
                NumberOfNights = 1,
                CostVacationer = 1000,
                NumberOfVacationer = 12,
                WiFi = true,
                Surcharges = 500
            };

            var updatedTour = new Tour
            {
                Id = model.Id,
                Direction = Direction.Turkish,
                DepartureDate = DateTime.Now.AddDays(7),
                NumberOfNights = 10,
                CostVacationer = 1500,
                NumberOfVacationer = 5,
                WiFi = false,
                Surcharges = 500
            };

            // Act
            await tourStorage.AddAsync(model);
            await tourStorage.EditAsync(updatedTour);
            var result = await tourStorage.GetAllAsync();
            var editedTour = result.FirstOrDefault(x => x.Id == model.Id);

            // Assert
            editedTour.Should().BeEquivalentTo(updatedTour);
        }


        /// <summary>
        /// Удаление тура.
        /// </summary>
        [Fact]
        public async Task DeleteShouldReturnTrueWhenTourExists()
        {
            // Arrange
            var model = DateGenerate.CreateTour();

            // Act
            await tourStorage.AddAsync(model);
            var result = await tourStorage.DeleteAsync(model.Id);
            var toursAfterDeletion = await tourStorage.GetAllAsync();

            // Assert
            result.Should().BeTrue();
            toursAfterDeletion.Should().NotContain(x => x.Id == model.Id);
        }

        /// <summary>
        /// При пустом списке нет ошибок.
        /// </summary>
        [Fact]
        public async Task GetAllShouldNotThrow()
        {
            // Act
            Func<Task> act = () => tourStorage.GetAllAsync();

            // Assert
            await act.Should().NotThrowAsync();
        }

        /// <summary>
        /// Получает пустой список.
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnEmpty()
        {
            // Act
            var result = await tourStorage.GetAllAsync();

            // Assert
            result.Should().NotBeNull().And.BeEmpty();
        }
        
    }
}
