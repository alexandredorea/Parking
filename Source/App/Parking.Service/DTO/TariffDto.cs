using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Service.DTO
{
    public class TariffDto
    {
        public decimal ValueHour { get; set; }

        public decimal AdditionalValueHour { get; set; }

        public DateTime StartEffectiveDate { get; set; }

        public DateTime LastEffectiveDate { get; set; }
    }
}
