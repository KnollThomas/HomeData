using System;
using System.Collections.Generic;
using System.Text;

namespace Application.VMs
{
    public class TemperatureRecordsVm 
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        IList<TemperatureRecordVm> Records { get; set; }
    }
}
