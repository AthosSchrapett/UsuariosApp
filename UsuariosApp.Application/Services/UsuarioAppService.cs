﻿using UsuariosApp.Application.Interfaces;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;
using UsuariosApp.Domain.Interfaces.Services;
using UsuariosApp.Domain.Models;

namespace UsuariosApp.Application.Services;

public class UsuarioAppService : IUsuarioAppService
{
    public readonly IUsuarioDomainService _usuarioDomainService;

    public UsuarioAppService(IUsuarioDomainService usuarioDomainService)
    {
        _usuarioDomainService = usuarioDomainService;
    }

    public AutenticarResponseDTO Autenticar(AutenticarRequestDTO dto)
    {
        throw new NotImplementedException();
    }

    public CriarContaResponseDTO CriarConta(CriarContaRequestDTO dto)
    {
        var usuario = new Usuario
        {
            Id = Guid.NewGuid(),
            Nome = dto.Nome,
            Email = dto.Email,
            Senha = dto.Senha,
            DataHoraCriacao = DateTime.UtcNow
        };

        _usuarioDomainService.CriarConta(usuario);

        return new CriarContaResponseDTO
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            DataHoraCriacao = usuario.DataHoraCriacao
        };
    }
    public void Dispose()
    {
        _usuarioDomainService?.Dispose();
    }
}
