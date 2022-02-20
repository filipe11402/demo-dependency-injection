using API.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Services.MultiInjections
{
    public class CarServiceFactory : ICarServiceFactory
    {
        private readonly IEnumerable<ICarService> _carServices;

        public CarServiceFactory(IEnumerable<ICarService> carServices)
        {
            this._carServices = carServices;
        }

        public ICarService GetCarService(CarBrandEnum carBrand)
        {
            return this._carServices.FirstOrDefault(x => x.GetCarBrand() == carBrand);
        }
    }
}
