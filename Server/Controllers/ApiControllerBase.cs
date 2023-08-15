using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : Controller
{
}
