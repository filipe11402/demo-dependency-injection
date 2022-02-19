using API.Services.LifeCyles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifeCyleController : ControllerBase
    {
        private readonly ISingletonService _singletonService;

        private readonly LifeCycleService _lifeCycleService;

        public LifeCyleController(ISingletonService singletonService,
                                  LifeCycleService lifeCycleService)
        {
            this._singletonService = singletonService;
            this._lifeCycleService = lifeCycleService;
        }

        [HttpGet]
        [Route("singleton")]
        public IActionResult GetSingleton() 
        {
            return StatusCode(StatusCodes.Status200OK,
            new 
            {
                result = this._singletonService.GetInstantiationCount()
            });
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllLifeCycles()
        {
            return StatusCode(StatusCodes.Status200OK,
            new
            {
                result = this._lifeCycleService.GetLifeCyclesServicesInfo()
            });
        }
    }
}
