// REST API using ASP.NET Core (Basic) 
using System;
using Microsoft.AspNetCore.Mvc; 

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("add")]
    public IActionResult Add(int a, int b)
    {
        int result = a + b;
        return Ok(result);
    }
}