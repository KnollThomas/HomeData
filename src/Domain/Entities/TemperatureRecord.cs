using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TemperatureRecord //: AuditableEntity
    {
        public TemperatureRecord()
        {

        }

        public int Id { get; set; }
        public double Value { get; set; }

        public Category Category { get; set; } 

    }
}
