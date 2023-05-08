using UsuariosApp.Application.Interfaces;
using UsuariosApp.Application.Services;

namespace UsuariosApp.Api.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IUsuarioAppService, UsuarioAppService>();

        return services;
    }
}
