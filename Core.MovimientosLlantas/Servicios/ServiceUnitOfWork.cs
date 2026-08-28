namespace Core.MovimientosLlantas.Servicios
{
    using System;
    using Core.MovimientosLlantas.Interface;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Implementación de la unidad de trabajo de servicios con inicialización lazy.
    /// </summary>
    public class ServiceUnitOfWork : IServiceUnitOfWork
    {
        private readonly IServiceProvider _serviceProvider;
        private ILlantasService _llantasService;

        /// <summary>
        /// Inicializa una nueva instancia de la clase ServiceUnitOfWork.
        /// </summary>
        /// <param name="serviceProvider">Proveedor de servicios para instanciación lazy.</param>
        public ServiceUnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <value>
        /// Obtiene el servicio de llantas inicializado de forma lazy.
        /// </value>
        public ILlantasService LlantasService =>
    _llantasService ??= _serviceProvider.GetRequiredService<ILlantasService>();
    }
}