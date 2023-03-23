using Microsoft.AspNetCore.Mvc;

namespace MicroHomework.WebApi.Controllers;

[ApiController]
[Route("healthcheck")]
public class HealthCheckController : ControllerBase
{
    
    public HealthCheckController()
    {
    }

    [HttpGet("ping")]
    public IActionResult Get()
    {
        return Ok("pong");
    }
}