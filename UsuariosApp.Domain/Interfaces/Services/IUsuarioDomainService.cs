using UsuariosApp.Domain.Models;

namespace UsuariosApp.Domain.Interfaces.Services;

public interface IUsuarioDomainService : IDisposable
{
    public void CriarConta(Usuario usuario);
}
