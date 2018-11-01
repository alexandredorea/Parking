using Flunt.Validations;
using Parking.Domain.Entities.Base;
using System;

namespace Parking.Domain.Entities
{
    public class Tariff : EntityBase<int>
    {
        #region Contrutores

        public Tariff(decimal additionalValueHour, decimal valueHour, DateTime startEffectiveDate, DateTime lastEffectiveDate)
        {
            AdditionalValueHour = additionalValueHour;
            ValueHour = valueHour;
            StartEffectiveDate = startEffectiveDate;
            LastEffectiveDate = lastEffectiveDate;
        }

        #endregion

        #region Atributos

        public decimal ValueHour { get; private set; }

        public decimal AdditionalValueHour { get; private set; }

        public DateTime StartEffectiveDate { get; private set; }

        public DateTime LastEffectiveDate { get; private set; }

        #endregion

        #region Métodos

        public void SetValueHour(decimal value)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, value, "Tariff.ValueHour", "O valor hora deve ser maior que zero."));

            if (Valid)
                ValueHour = value;
        }

        public void SetAdditionalValueHour(decimal value)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, value, "Tariff.AdditionalValueHour", "O valor hora adicional deve ser maior que zero."));

            if (Valid)
                AdditionalValueHour = value;
        }

        public void SetStartEffectiveDate(DateTime date)
        {
            StartEffectiveDate = date;
        }

        public void SetLastEffectiveDate(DateTime date)
        {
            LastEffectiveDate = date;
        }

        #endregion
    }
}
