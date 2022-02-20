using API.Enums;

namespace API.Services.MultiInjections
{
    public class PorscheService : ICarService
    {
        public string GetBrandInfo()
        {
            return "Creator -> Ferdinand Porsche";
        }

        public CarBrandEnum GetCarBrand()
        {
            return CarBrandEnum.Porsche;
        }
    }
}
