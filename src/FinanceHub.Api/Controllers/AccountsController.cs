using FinanceHub.Api.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FinanceHub.Api.Controllers;

[Route("/[controller]")]
[ApiController]
public class AccountsController : ControllerBase
{
    /// <summary>
    /// Cria uma nova conta financeira para o usuário autenticado.
    /// </summary>
    /// <param name="request">Dados da conta a ser criada.</param>
    /// <response code="201">Conta criada com sucesso.</response>
    /// <response code="400">Dados inválidos.</response>
    [HttpPost]
    public IActionResult CreateAccount([FromBody] RequestAccount request)
    {
        return Created();
    }
}