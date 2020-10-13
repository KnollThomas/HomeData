using Application.Interfaces;
using Domain.Entities;
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
        public List<TemperatureRecords> Temperatures { get; set; }
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
            foreach (var entity in request.Temperatures)
            {
                _context.Temperatures.Add(entity);
            }

            await _context.SaveChangesAsync(cancellationToken);

            return request.Temperatures.Select(x => x.Id).ToList();
        }
    }

}
