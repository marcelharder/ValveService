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

[HttpGet("getSizesForValve/{id}")]
public async Task<IActionResult> getSizesForValve(int id)
{
  var result = await _code.getSizesForValve(id);
  return Ok(result);
}


}