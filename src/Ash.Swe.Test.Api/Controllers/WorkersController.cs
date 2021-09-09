using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ash.Swe.Test.Api.ViewModels;
using Ash.Swe.Test.Data.Enum;
using Ash.Swe.Test.Api.Services;
namespace Ash.Swe.Test.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkersController : ControllerBase
    {
        private readonly ILogger<WorkersController> _logger;
        private readonly WorkerService _workerService;

        public WorkersController(ILogger<WorkersController> logger, WorkerService workerService)
        {
            _logger = logger;
            _workerService = workerService;
        }

        [HttpGet]
        [Route("/workers")]
        public Task<List<WorkerVM>> GetWorkers() {
            return _workerService.GetWorkers();
        }

        [HttpPost]
        [Route("/worker")]
        public Task<WorkerVM> AddWorker([FromBody] WorkerVM vm) {
            return _workerService.AddWorker(vm);

        }
    }
}
