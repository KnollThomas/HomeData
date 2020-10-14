using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{

    public class CreateTemperatureItemsCommand : IRequest<List<int>>
    {
        public List<TemperatureRecordDto> Temperatures { get; set; }
    }

    public class TemperatureRecordDto
    {        
        public double Value { get; set; }
        public Category Category { get; set; }
    }


    public class CreateTemperatureItemsCommandHandler : IRequestHandler<CreateTemperatureItemsCommand, List<int>>
    {
        private readonly IApplicationDbContext _context;

        public CreateTemperatureItemsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<int>> Handle(CreateTemperatureItemsCommand request, CancellationToken cancellationToken)
        {
            var ret = new List<TemperatureRecord>();

            foreach (var requestItem in request.Temperatures)
            {
                var entity = new TemperatureRecord()
                {
                    Id = 0,
                    Value = requestItem.Value,
                    Category = requestItem.Category,
                };

                _context.Temperatures.Add(entity);
                ret.Add(entity);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return ret.Select(x => x.Id).ToList() ;
        }
    }

}
