﻿using UsuariosApp.Domain.Interfaces.Repositories;
using UsuariosApp.Domain.Models;
using UsuariosApp.Infra.Data.Contexts;
using UsuariosApp.Infra.Data.Repositories.Base;

namespace UsuariosApp.Infra.Data.Repositories;

public class UsuarioRepository : BaseRepository<Usuario, Guid>, IUsuarioRepository
{
    private readonly DataContext? _dataContext;

    public UsuarioRepository(DataContext? dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }
}
