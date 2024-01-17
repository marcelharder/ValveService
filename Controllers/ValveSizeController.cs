using System.Security.Permissions;
using ValveService.interfaces;

namespace ValveService.Controllers;

[ApiController]
[Route("[controller]")]
public class ValveSizeController : ControllerBase
{
    private IValveCode _code;

    public ValveSizeController(IValveCode code)
    {
        _code = code;
    }

[HttpGet("{id}")]
public async Task<IActionResult> getValveCodes(int id)
{
  var result = await _code.getSize(id);
  return Ok(result);
}


}