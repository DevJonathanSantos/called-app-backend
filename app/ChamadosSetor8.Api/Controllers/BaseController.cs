using ChamadosSetor8.Business.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class BaseController : ControllerBase
{
    protected IActionResult ToHttpResult(ApiResult apiResult)
    {

        if (apiResult.StatusCode == StatusCodes.Status200OK) return Ok(apiResult);
        if (apiResult.StatusCode == StatusCodes.Status204NoContent) return StatusCode(StatusCodes.Status204NoContent);
        if (apiResult.StatusCode == StatusCodes.Status400BadRequest) return BadRequest(apiResult);
        if (apiResult.StatusCode == StatusCodes.Status401Unauthorized) return Unauthorized(apiResult);
        if (apiResult.StatusCode == StatusCodes.Status500InternalServerError) return StatusCode(StatusCodes.Status500InternalServerError, apiResult);

        throw new NotImplementedException($"Code {apiResult.StatusCode} has not been implemented on method 'ToHttpResult'");
    }
}