using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Text;

namespace UsuariosApp.Tests.Helpers;

public class TestHelper
{
    /// <summary>
    /// Método para criar um client http da api de usuários
    /// </summary>
     public static HttpClient CreateClient
        => new WebApplicationFactory<Program>().CreateClient();

    /// <summary>
    /// Método para serializar o contedo da requisição que será enviada para um serviço
    /// </summary>
    public static StringContent CreateContent<TRequest>(TRequest request)
        => new(JsonConvert.SerializeObject(request),
            Encoding.UTF8, "application/json");
    /// <summary>
    /// Método para deserializar o retorno obtido pela execução de um serviço
    /// </summary>
    public static TResponse ReadResponse<TResponse>(HttpResponseMessage message)
        => JsonConvert.DeserializeObject<TResponse>(message.Content.ReadAsStringAsync().Result);
}
