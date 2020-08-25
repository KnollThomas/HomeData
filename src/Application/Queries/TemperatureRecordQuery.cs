using Application.Interfaces;
using Application.VMs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class TemperatureRecordQuery : IRequest<TemperatureRecordsVm>
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class TemperatureRecordQueryHandler : IRequestHandler<TemperatureRecordQuery, TemperatureRecordsVm>
    {
        private readonly IApplicationDbContext context;

        public TemperatureRecordQueryHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<TemperatureRecordsVm> Handle(TemperatureRecordQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
