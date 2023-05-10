using Microsoft.AspNetCore.Mvc;
using UsuariosApp.Application.Interfaces;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;

namespace UsuariosApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarioAppService? _usuarioAppService;

    public UsuariosController(IUsuarioAppService? service)
    {
        _usuarioAppService = service;
    }

    /// <summary>
    /// Autenticação de usuários
    /// </summary>
    [HttpPost]
    [Route("autenticar")]
    [ProducesResponseType(typeof(AutenticarResponseDTO), StatusCodes.Status200OK)]
    public IActionResult Autenticar(AutenticarRequestDTO dto)
    {
        return Ok();
    }

    /// <summary>
    /// Criação de usuários
    /// </summary>
    [HttpPost]
    [Route("criar-conta")]
    [ProducesResponseType(typeof(CriarContaResponseDTO), StatusCodes.Status201Created)]
    public IActionResult CriarConta(CriarContaRequestDTO dto)
    {
        return StatusCode(201, _usuarioAppService?.CriarConta(dto));
    }
}
