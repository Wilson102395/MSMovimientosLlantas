namespace Infrastructure.MovimientosLlantas.Extensiones
{
    using Microsoft.Extensions.DependencyInjection;
    using Core.MovimientosLlantas.Interface;
    using Core.MovimientosLlantas.Servicios;

    /// <summary>
    /// Contiene los métodos de extensión para registrar las dependencias del sistema.
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Registra todos los servicios y repositorios en el contenedor de dependencias.
        /// </summary>
        /// <param name="services">La colección de servicios de .NET.</param>
        /// <returns>La colección de servicios modificada.</returns>
        public static IServiceCollection InyeccionDependencias(this IServiceCollection services)
        {
            // Aquí le enseñamos a .NET qué clase usar cuando alguien pida una interfaz.
            // Usamos AddScoped para que se cree uno nuevo por cada petición web del cliente.
            services.AddScoped<ILlantasService, LlantasService>();
            services.AddScoped<IServiceUnitOfWork, ServiceUnitOfWork>();

            return services;
        }
    }
}