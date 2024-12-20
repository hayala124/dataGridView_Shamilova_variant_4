﻿using System;
using dataGridView.Contracts.Models;
 
namespace dataGridView_Shamilova_variant_4.Bindings
{
    public class DateGenerate
    {
        /// <summary>
        /// Метод инициализирует новый экземпляр класса<see cref="Tour"/>
        /// </summary>
        public static Tour CreateTour(Action<Tour> settings = null)
        {
            var result = new Tour()
            {
                Id = Guid.NewGuid(),
                Direction = Direction.France,
                DepartureDate = DateTime.Now.AddDays(15),
                NumberOfNights = 2,
                CostVacationer = 2,
                NumberOfVacationer = 5,
                WiFi = true,
                Surcharges = 0,
            };

            result.TotalCost = result.CostVacationer * result.NumberOfVacationer + result.Surcharges;
            settings?.Invoke(result);

            return result;
        }
    }
}
