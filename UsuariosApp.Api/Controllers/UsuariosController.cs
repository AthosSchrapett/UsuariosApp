using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsuariosApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        /// <summary>
        /// Autenticação de usuários
        /// </summary>
        [HttpPost("autenticar")]
        public IActionResult Autenticar()
        {
            return Ok();
        }

        /// <summary>
        /// Criação de usuários
        /// </summary>
        [HttpPost("criar-conta")]
        public IActionResult CriarConta()
        {
            return Ok();
        }
    }
}
