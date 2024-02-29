using Microsoft.AspNetCore.Mvc;

namespace AsianKitchen.Api.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }

}