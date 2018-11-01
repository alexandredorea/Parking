using Flunt.Validations;
using Parking.Domain.Entities.Base;
using System;

namespace Parking.Domain.Entities
{
    public class Parking : EntityBase<string>
    {
        #region Contrutores

        public Parking(string licensePlate, DateTime checkIn, decimal price)
        {
            AddNotifications(new Contract()
                .Requires()
                .Matchs(licensePlate, "[A-Z]{3}[0-9]{4}", "Parking.LicensePlate", "A placa é inválida."));

            if (Valid)
                SetId(licensePlate);

            SetCheckIn(checkIn);
            SetPrice(price);
        }

        #endregion

        #region Atributos

        public DateTime CheckIn { get; private set; }

        public DateTime? CheckOut { get; private set; }

        public TimeSpan? DurationParking { get; private set; }
        
        public int? HoursCharged { get; private set; }

        public decimal Price { get; private set; }

        public decimal? AmountToPay { get; private set; }

        #endregion

        #region Métodos

        public void SetCheckIn(DateTime checkIn)
        {
            CheckIn = checkIn;
        }

        public void SetCheckOut(DateTime checkOut)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerThan(checkOut, CheckIn, "Parking.CheckOut", "A data de saída deve ser menor que a data e hora de entrada."));

            if (Valid)
                CheckOut = checkOut;
        }

        public void SetDurationParking(TimeSpan duration)
        {
            DurationParking = duration;
        }

        public void SetHoursCharged(int hoursCharged)
        {
            HoursCharged = hoursCharged;
        }

        public void SetPrice(decimal price)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, price, "Parking.Price", "A tarifa deve ser maior que zero."));

            if (Valid)
                Price = price;
        }

        public void SetAmountToPay(decimal amountToPay)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, amountToPay, "Parking.AmountToPay", "O valor a pagar deve ser maior que zero."));

            if (Valid)
                AmountToPay = amountToPay;
        }

        #endregion
    }
}