using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class RegistrationController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return ("Registration/Index fired");
        }

        [HttpPost]
        public string Post1()
        {
            return ("Registration/Post1 fired");
        }

    }
}