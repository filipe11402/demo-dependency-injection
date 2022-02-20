using API.Enums;
using API.Services.MultiInjections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiInjectionController : ControllerBase
    {
        private readonly ICarServiceFactory _carFactory;

        public MultiInjectionController(ICarServiceFactory carFactory)
        {
            this._carFactory = carFactory;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult GetCar() 
        {
            return StatusCode(StatusCodes.Status200OK,
                new
                {
                    Ferrari = this._carFactory.GetCarService(CarBrandEnum.Ferrari).GetBrandInfo(),
                    Porsche = this._carFactory.GetCarService(CarBrandEnum.Porsche).GetBrandInfo(),
                    Bugatti = this._carFactory.GetCarService(CarBrandEnum.Bugatti).GetBrandInfo()
                });
        }
    }
}
