namespace API.Services.LifeCyles
{
    public class LifeCycleService
    {
        private readonly ISingletonService _singletonService;

        private readonly ITransientService _transientService;

        public LifeCycleService(ISingletonService singletonService,
                                ITransientService transientService)
        {
            this._singletonService = singletonService;
            this._transientService = transientService;
        }

        public string GetLifeCyclesServicesInfo() 
        {
            return $"{nameof(ISingletonService)} - {this._singletonService.GetId()}" + 
                   $"{System.Environment.NewLine}" +
                   $"{nameof(ITransientService)} - {this._transientService.GetId()}";
        }
    }
}
