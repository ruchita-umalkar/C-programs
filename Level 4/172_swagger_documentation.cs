// REST API with Swagger Documentation 

using System;
using Microsoft.AspNetCore.Mvc; 
[ApiController]
[Route("api/[controller]")] 
public class CalculatorController : ControllerBase
{
    /// <summary>
    /// Adds two integers and returns the result.
    /// </summary>
    /// <param name="a">First integer</param>
    /// <param name="b">Second integer</param>
    /// <returns>The sum of a and b</returns>
    [HttpGet("add")]
    public IActionResult Add(int a, int b)
    {
        int result = a + b;
        return Ok(result);
    }
}