using IocLifeTimes.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IocLifeTimes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GuidController : ControllerBase
{
    private readonly ISingletonGuidService _singleton1;
    private readonly ISingletonGuidService _singleton2;

    private readonly IScopedGuidService _scoped1;
    private readonly IScopedGuidService _scoped2;

    private readonly ITransientGuidService _transient1;
    private readonly ITransientGuidService _transient2;

    public GuidController(ISingletonGuidService singleton1, ISingletonGuidService singleton2, IScopedGuidService scoped1, IScopedGuidService scoped2, ITransientGuidService transient1, ITransientGuidService transient2)
    {
        _singleton1 = singleton1;
        _singleton2 = singleton2;
        _scoped1 = scoped1;
        _scoped2 = scoped2;
        _transient1 = transient1;
        _transient2 = transient2;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            singleton = new { _singleton1 = _singleton1.GetGuid(), _singleton2 = _singleton2.GetGuid() },
            scoped = new { _scoped1 = _scoped1.GetGuid(), _scoped2 = _scoped2.GetGuid() },
            transient = new { _transient1 = _transient1.GetGuid(), _transient2 = _transient2.GetGuid() }
        });
    }

}
