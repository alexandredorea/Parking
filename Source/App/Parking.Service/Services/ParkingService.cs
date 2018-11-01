using Parking.Domain.Entities;
using Parking.Domain.Interfaces.Repositories;
using Parking.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Service.Services
{
    public class ParkingService : IParkingService
    {
        private readonly IParkingRepository _parkingRepository;

        public ParkingService(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        public decimal CalculatePayment(TimeSpan durationParking, decimal valueHour, decimal additionalValueHour)
        {
            return new Payment().CalculatePayment(durationParking, valueHour, additionalValueHour);
        }
    }
}
