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
        public async Task<ActionResult<List<WorkerVM>>> GetWorkersAsync() {
            return await  _workerService.GetWorkersAsync();
        }

        [HttpPost]
        [Route("/worker")]
        public async Task<ActionResult<WorkerVM>> AddWorkerAsync([FromBody] WorkerVM vm) {
            try {
                return await _workerService.AddWorkerAsync(vm);
            } catch (Exception e) {
                _logger.LogError(e, e.Message);
                return StatusCode(500); // hide stack trace
            }


        }
    }
}
