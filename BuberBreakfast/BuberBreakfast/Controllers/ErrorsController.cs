using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        // Returns an appropriate error message
        return Problem();
    }
}