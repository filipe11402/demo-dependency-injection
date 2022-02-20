using API.Enums;

namespace API.Services.MultiInjections
{
    public interface ICarServiceFactory
    {
        ICarService GetCarService(CarBrandEnum carBrand);
    }
}
