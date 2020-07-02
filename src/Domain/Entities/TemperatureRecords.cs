using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TemperatureRecords : AuditableEntity
    {
        public int Id { get; set; }
        public double Value { get; set; }

        public int Category { get; set; } // TODo Change to enum or value object class

    }
}
