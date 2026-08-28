namespace Core.MovimientosLlantas.Interface
{
    /// <summary>
    /// Contrato para la unidad de trabajo que agrupa todos los servicios de negocio.
    /// </summary>
    public interface IServiceUnitOfWork
    {
        /// <value>
        /// Obtiene el servicio encargado de la gestión de llantas.
        /// </value>
        ILlantasService LlantasService { get; }
    }
}