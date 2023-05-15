using Bogus;
using FluentAssertions;
using System.Net;
using UsuariosApp.Application.Models.Requests;
using UsuariosApp.Application.Models.Responses;
using UsuariosApp.Tests.Helpers;
using Xunit;

namespace UsuariosApp.Tests;

public class UsuariosTest
{
    [Fact]
    public async Task<CriarContaResponseDTO> Usuario_Post_CriarConta_Returns_Created()
    {
        var faker = new Faker("pt_BR");
        var request = new CriarContaRequestDTO
        {
            Nome = faker.Person.FullName,
            Email = faker.Internet.Email(),
            Senha = /*faker.Internet.Password(10),*/ "@Teste123"
        };

        var content = TestHelper.CreateContent(request);
        var result = await TestHelper.CreateClient.PostAsync("/api/usuarios/criar-conta", content);

        result.StatusCode.Should().Be(HttpStatusCode.Created);

        var response = TestHelper.ReadResponse<CriarContaResponseDTO>(result);

        response.Id.Should().NotBeEmpty();
        response.Nome.Should().NotBeEmpty(request.Nome);
        response.Email.Should().NotBeEmpty(request.Email);
        response.DataHoraCriacao.Should().NotBeNull();

        return response;
    }

    [Fact]
    public async void Usuario_CriarConta_Returns_BadRequest()
    {
        var usuario = await Usuario_Post_CriarConta_Returns_Created();

        var request = new CriarContaRequestDTO
        {
            Nome = usuario.Nome,
            Email = usuario.Email,
            Senha = "@Teste123"
        };

        var content = TestHelper.CreateContent(request);
        var result = await TestHelper.CreateClient.PostAsync("/api/usuarios/criar-conta", content);

        result.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact(Skip = "Não implementado")]
    public void Usuario_Post_Autenticar_Returns_Ok()
    {
        //TODO
    }

    [Fact(Skip = "Não implementado")]
    public void Usuario_Post_Autenticar_Returns_Unauthorized()
    {
        //TODO
    }

}
