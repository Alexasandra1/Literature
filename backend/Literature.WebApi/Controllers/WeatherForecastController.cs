using Literature.Database;
using Literature.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Literature.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public WeatherForecastController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IntDTO GetInt()
        {
            return new IntDTO() { Unicorn = 5 };
        }
    }
}