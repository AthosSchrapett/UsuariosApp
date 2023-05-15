using System;

namespace UsuarioApp.Test.Helpers

public static class TestHelper
{
    public static HttpClient CreateClient
        => new WebApplicationFactory<Program>().CreateClient;
}
