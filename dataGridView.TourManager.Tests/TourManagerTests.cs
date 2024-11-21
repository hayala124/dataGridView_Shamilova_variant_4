using dataGridView.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Microsoft.Extensions.Logging;
using Xunit;
using dataGridView_Shamilova_variant_4.Bindings;
using dataGridView.Contracts.Models;
using FluentAssertions;

namespace dataGridView.TourManager.Tests
{
    /// <summary>
    /// Тесты для <see cref="TourManager"/>
    /// </summary>
    public class TourManagerTests
    {
        private readonly ITourManager tourManager;
        private readonly Mock<ITourStorage> tourStorageMock;
        private readonly Mock<ILogger> loggerMock;

        /// <summary>ctor</summary>
        public TourManagerTests()
        {
            tourStorageMock = new Mock<ITourStorage>();

            loggerMock = new Mock<ILogger>();
            loggerMock.Setup(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()));

            tourManager = new TourManager(tourStorageMock.Object, loggerMock.Object);
        }

        /// <summary>
        /// <inheritdoc cref="ITourManager.AddAsync(Tour)"/>
        /// </summary>
        [Fact]
        public async Task AddShouldWork()
        {
            // Arrange.
            var model = DateGenerate.CreateTour();
            tourStorageMock.Setup(x => x.AddAsync(It.IsAny<Tour>())).ReturnsAsync(model);

            // Act.
            var result = await tourManager.AddAsync(model);

            // Assert.
            result.Should().NotBeNull().And.Be(model);

            tourStorageMock.Verify(x => x.AddAsync(It.Is<Tour>(y => y.Id == model.Id)), Times.Once);
            tourStorageMock.VerifyNoOtherCalls();

            loggerMock.Verify(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()), Times.Once());
            loggerMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// <inheritdoc cref="ITourManager.DeleteAsync(Guid)"/>
        /// </summary>
        [Fact]
        public async Task DeleteShouldWork()
        {
            // Arrange.
            var modelId = Guid.NewGuid();
            tourStorageMock.Setup(x => x.DeleteAsync(modelId)).ReturnsAsync(true);

            // Act.
            var result = await tourManager.DeleteAsync(modelId);

            // Assert.
            result.Should().BeTrue();

            tourStorageMock.Verify(x => x.DeleteAsync(modelId), Times.Once);
            tourStorageMock.VerifyNoOtherCalls();

            loggerMock.Verify(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()), Times.Once());
            loggerMock.VerifyNoOtherCalls();
        }


        /// <summary>
        /// <inheritdoc cref="ITourManager.EditAsync(Tour)"/>
        /// </summary>
        [Fact]
        public async Task EditShouldWork()
        {
            // Arrange.
            var model = new Tour()
            {
                Id = Guid.NewGuid(),
                Direction = Direction.Turkish,
                DepartureDate = DateTime.Now.AddDays(23),
                NumberOfNights = 2,
                CostVacationer = 500,
                NumberOfVacationer = 10,
                WiFi = true,
                Surcharges = 479,
            };

            tourStorageMock.Setup(x => x.EditAsync(It.IsAny<Tour>()));

            // Act.
            await tourManager.EditAsync(model);

            // Assert.
            tourStorageMock.Verify(x => x.EditAsync(It.Is<Tour>(y => y.Id == model.Id)), Times.Once);
            tourStorageMock.VerifyNoOtherCalls();

            loggerMock.Verify(x => x.Log(LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                null,
                It.IsAny<Func<It.IsAnyType, Exception, string>>()), Times.Once());
            loggerMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// <inheritdoc cref="ITourManager.GetAllAsync"/>
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnAllTours()
        {
            // Arrange.
            var tour = new List<Tour>()
            {
                DateGenerate.CreateTour(),
                new Tour
                {
                    Id = Guid.NewGuid(),
                    Direction = Direction.Turkish,
                    DepartureDate = DateTime.Now.AddDays(50),
                    NumberOfNights = 2,
                    CostVacationer = 1300,
                    NumberOfVacationer = 17,
                    WiFi = false,
                    Surcharges = 50000,
                }
            };
            tourStorageMock.Setup(x => x.GetAllAsync()).ReturnsAsync(tour);

            // Act.
            var result = await tourManager.GetAllAsync();

            // Assert.
            result.Should().BeEquivalentTo(tour);

            tourStorageMock.Verify(x => x.GetAllAsync(), Times.Once);
            tourStorageMock.VerifyNoOtherCalls();

            loggerMock.VerifyNoOtherCalls();
        }

        /// <summary>
        /// <inheritdoc cref="ITourManager.GetStatsAsync"/>
        /// </summary>
        [Fact]
        public async Task GetStatsShouldRight()
        {
            // Arrange.
            var tour = new List<Tour>()
            {
                DateGenerate.CreateTour(),
                new Tour
                {
                    Id = Guid.NewGuid(),
                    Direction = Direction.Turkish,
                    DepartureDate = DateTime.Now.AddDays(50),
                    NumberOfNights = 2,
                    CostVacationer = 1300,
                    NumberOfVacationer = 17,
                    WiFi = false,
                    Surcharges = 50000,
                }
            };
            tourStorageMock.Setup(x => x.GetAllAsync()).ReturnsAsync(tour);

            // Act.
            var result = await tourManager.GetStatsAsync();

            // Assert.
            result.TotalCountTours.Should().Be(tour.Count);
            result.TotalCostTours.Should().Be(tour.DefaultIfEmpty(new Tour()).Sum(x => x.TotalCost));
            result.CountToursWithSurcharges.Should().Be(tour.Where(x => x.Surcharges > 0).Count());
            result.TotalCostOfSurcharges.Should().Be(tour.DefaultIfEmpty(new Tour()).Sum(x => x.Surcharges));

            tourStorageMock.Verify(x => x.GetAllAsync(), Times.Once);
            tourStorageMock.VerifyNoOtherCalls();

            loggerMock.VerifyNoOtherCalls();
        }

    }
}
