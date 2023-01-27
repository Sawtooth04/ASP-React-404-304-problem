using Microsoft.AspNetCore.Mvc;

public class TestController : Controller
{
    [HttpGet]
    public IActionResult GetTest()
    {
        return Ok("Test/Index fired");
    }
}
