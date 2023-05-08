﻿namespace UsuariosApp.Application.Models.Responses;

public class CriarContaResponseDTO
{
    public Guid? Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public DateTime? DataHoraExpiracao { get; set; }
}
