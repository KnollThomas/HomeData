using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Queries;
using Application.VMs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TemperatureRecordsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<TemperatureRecordsVm>> Get()
        {
            return await Mediator.Send(new TemperatureRecordQuery());
        }
    }
}
