namespace API.Services.MultiInjections
{
    public class PorscheService : ICarService
    {
        public string GetBrand()
        {
            return "Porsche";
        }
    }
}
