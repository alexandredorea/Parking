using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Service.Interfaces
{
    public interface IParkingService
    {
        decimal CalculatePayment(TimeSpan durationParking, decimal valueHour, decimal additionalValueHour);
    }
}
