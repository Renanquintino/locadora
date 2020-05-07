﻿using Pereirão.Entities;
using System;

namespace Pereirão.Services.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService()
        {
        }
        private ITaxservice _taxServices;

        public RentalService(double pricePerHour, double pricePerDay, ITaxservice taxServices)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxServices = taxServices;





























































































































































































































        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours < 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);


            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }


        }
    }
}
