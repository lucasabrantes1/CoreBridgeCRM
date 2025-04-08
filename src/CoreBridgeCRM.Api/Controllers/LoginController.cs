using CoreBridgeCRM.Application.UseCases.Login.DoLogin;
using CoreBridgeCRM.Communication.Requests;
using CoreBridgeCRM.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CoreBridgeCRM.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> Login(
        [FromServices] IDoLoginUseCase useCase,
        [FromBody] RequestLoginJson request)
    {
        var response = await useCase.Execute(request);

        return Ok(response);
    }
}
