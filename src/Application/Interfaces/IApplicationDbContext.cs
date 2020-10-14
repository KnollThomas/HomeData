using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TemperatureRecord> Temperatures { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }

}
