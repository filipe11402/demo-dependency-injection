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

        private readonly ITransientService _transientService;

        private readonly LifeCycleService _lifeCycleService1;

        private readonly LifeCycleService _lifeCycleService2;

        public LifeCyleController(ISingletonService singletonService,
                                  ITransientService transientService,
                                  LifeCycleService lifeCycleService1,
                                  LifeCycleService lifeCycleService2)
        {
            this._singletonService = singletonService;
            this._transientService = transientService;
            this._lifeCycleService1 = lifeCycleService1;
            this._lifeCycleService2 = lifeCycleService2;
        }

        [HttpGet]
        [Route("singleton")]
        public IActionResult GetSingleton() 
        {
            return StatusCode(StatusCodes.Status200OK,
            new 
            {
                result = this._singletonService.GetId()
            });
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllLifeCycles()
        {
            return StatusCode(StatusCodes.Status200OK,
            new
            {
                result = $"{this._lifeCycleService1.GetLifeCyclesServicesInfo()}" +
                         $"{System.Environment.NewLine}" +
                         $"{this._lifeCycleService2.GetLifeCyclesServicesInfo()}"
            });
        }

        [HttpGet]
        [Route("transient")]
        public IActionResult GetTransient()
        {
            return StatusCode(StatusCodes.Status200OK,
            new
            {
                result = this._transientService.GetId()
            });
        }
    }
}
