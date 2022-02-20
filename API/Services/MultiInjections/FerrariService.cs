using API.Enums;

namespace API.Services.MultiInjections
{
    public class FerrariService : ICarService
    {
        public string GetBrandInfo()
        {
            return "Creator -> Enzo Ferrari";
        }

        public CarBrandEnum GetCarBrand()
        {
            return CarBrandEnum.Ferrari;
        }
    }
}
