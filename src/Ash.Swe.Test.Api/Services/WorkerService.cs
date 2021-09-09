using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ash.Swe.Test.Api.ViewModels;
using Ash.Swe.Test.Data.Enum;
namespace Ash.Swe.Test.Api.Services
{
    public class WorkerService {
        private readonly ILogger<WorkerService> _logger;

        public WorkerService(ILogger<WorkerService> logger)
        {
            _logger = logger;
        }

        public async Task<List<WorkerVM>> GetWorkersAsync() {
                    //TODO: get all workers
            return null;
        }

        public async Task<WorkerVM> AddWorkerAsync(WorkerVM workerVm) {
            if (workerVm.Title == EmployeeTypeEnum.Employee.ToString()) {
                //TODO: add new worker/employee
            } else if (workerVm.Title == EmployeeTypeEnum.Manager.ToString()) {
                //TODO: add new worker/manager
            } else if (workerVm.Title == EmployeeTypeEnum.Supervisor.ToString()) {
                //TODO: add new worker/supervisor
            } else {
                throw new Exception("Could not add worker");
            }

                    
                
                    
            return null;
        }




    }
}