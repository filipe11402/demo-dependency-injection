using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.LifeCyles
{
    public class LifeCycleService
    {
        private readonly ISingletonService _singletonService;

        public LifeCycleService(ISingletonService singletonService)
        {
            this._singletonService = singletonService;
        }

        public string GetLifeCyclesServicesInfo() 
        {
            return $@"{this._singletonService.GetInstantiationCount()} | {nameof(this._singletonService)}";
        }
    }
}
