using Microsoft.AspNetCore.Mvc;

namespace ContempProgrammingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { name = "Rohit Vijai" });
    }
}