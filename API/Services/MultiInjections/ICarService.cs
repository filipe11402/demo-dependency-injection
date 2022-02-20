using API.Enums;

namespace API.Services.MultiInjections
{
    public interface ICarService
    {
        CarBrandEnum GetCarBrand();

        string GetBrandInfo();
    }
}
