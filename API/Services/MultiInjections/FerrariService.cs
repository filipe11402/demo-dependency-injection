namespace API.Services.MultiInjections
{
    public class FerrariService : ICarService
    {
        public string GetBrand()
        {
            return "Ferrari";
        }
    }
}
