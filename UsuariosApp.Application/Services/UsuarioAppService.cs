﻿using UsuariosApp.Application.Interfaces;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;

namespace UsuariosApp.Application.Services;

public class UsuarioAppService : IUsuarioAppService
{
    public AutenticarResponseDTO Autenticar(AutenticarRequestDTO dto)
    {
        throw new NotImplementedException();
    }

    public CriarContaResponseDTO CriarConta(CriarContaRequestDTO dto)
    {
        throw new NotImplementedException();
    }
}