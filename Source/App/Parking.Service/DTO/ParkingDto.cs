using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Service.DTO
{
    public class ParkingDto
    {
        public string LicensePlate { get; set; }
        public DateTime CheckIn { get; set; }

        public DateTime? CheckOut { get; set; }

        public TimeSpan? DurationParking
        {
            get
            {
                return CheckOut?.Subtract(CheckIn);
            }
        }

        public int? HoursCharged { get; set; }

        public decimal Price { get; set; }

        public decimal? AmountToPay { get; set; }
    }
}
