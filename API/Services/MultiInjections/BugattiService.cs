using API.Enums;

namespace API.Services.MultiInjections
{
    public class BugattiService : ICarService
    {
        public string GetBrandInfo()
        {
            return "Creator -> Ettore Bugatti";
        }

        public CarBrandEnum GetCarBrand()
        {
            return CarBrandEnum.Bugatti;
        }
    }
}
