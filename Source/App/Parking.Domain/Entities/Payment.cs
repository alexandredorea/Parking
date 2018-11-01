using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Entities
{
    public class Payment
    {
        public decimal CalculatePayment(TimeSpan durationParking, decimal valueHour, decimal additionalValueHour)
        {
            var AmountToPayment = 0m;

            if ((durationParking.Hours == 0) && (durationParking.Minutes <= 30))
            {
                AmountToPayment = valueHour / 2;
            }
            else if ((durationParking.Hours > 0) && (durationParking.Minutes > 10))
            {
                AmountToPayment = valueHour + (additionalValueHour * durationParking.Hours);
            }
            else if ((durationParking.Hours > 0) && (durationParking.Minutes < 10))
            {
                AmountToPayment = valueHour + (additionalValueHour * (durationParking.Hours - 1));
            }
            else
            {
                AmountToPayment = valueHour;
            }

            return AmountToPayment;
        }
    }
}
