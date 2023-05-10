using UsuariosApp.Domain.Interfaces.Repositories.Base;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Domain.Interfaces.Repositories;

public interface IUsuarioRepository : IBaseRepository<Usuario, Guid>
{
}
