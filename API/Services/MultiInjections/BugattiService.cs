using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.MultiInjections
{
    public class BugattiService : ICarService
    {
        public string GetBrand()
        {
            return "Bugatti";
        }
    }
}
