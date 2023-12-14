#region usings
using Data.DB.Repositories;
using Domain.Interface.Repositories;
using Domain.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
#endregion

namespace InfraCode.IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ConfigureDependencyInjection(
        this IServiceCollection services,
        IConfiguration config)
    {
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        #region appsettings
        //services.Configure<TpClientConfiguration>(
        //    config.GetSection(ClientConfiguration.SectionName));

        //services.Configure<ConnectionStrings>(
        //    config.GetSection(ConnectionStrings.SectionName));

        //services.Configure<UploadConfiguration>(
        //    config.GetSection(UploadConfiguration.SectionName));
        #endregion

        #region Services

        services.AddScoped<IUnicaService, IUnicaService>();

        #endregion

        #region Repositories

        services.AddScoped<IUnicaRepository, UnicaRepository>();

        #endregion

        #region Clients

        #endregion

        return services;
    }

    public static IHostBuilder ConfigureLogging(
        this IHostBuilder host,
        IConfiguration configuration) => host.UseSerilog((_, config) => config.ReadFrom.Configuration(configuration));

}
