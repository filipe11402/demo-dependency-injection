namespace API.Services.LifeCyles
{
    public class LifeCycleService
    {
        private readonly ISingletonService _singletonService;

        private readonly ITransientService _transientService;

        private readonly IScopedService _scopedService;

        public LifeCycleService(ISingletonService singletonService,
                                ITransientService transientService,
                                IScopedService scopedService)
        {
            this._singletonService = singletonService;
            this._transientService = transientService;
            this._scopedService = scopedService;
        }

        public string GetLifeCyclesServicesInfo() 
        {
            return $"{nameof(ISingletonService)} - {this._singletonService.GetId()}" + 
                   $"{System.Environment.NewLine}" +
                   $"{nameof(ITransientService)} - {this._transientService.GetId()}" +
                   $"{System.Environment.NewLine}" +
                   $"{nameof(IScopedService)} - {this._scopedService.GetId()}";
        }
    }
}
