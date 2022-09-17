using Microsoft.AspNetCore.Mvc;
using PrototypeDesignPatternApp.Models;

namespace PrototypeDesignPatternApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUser _user;

        public WeatherForecastController(IUser user)
        {
            _user = user.Clone() as IUser;
        }

        [HttpGet]
        public IUser Get()
        {
            return _user;
        }
    }
}