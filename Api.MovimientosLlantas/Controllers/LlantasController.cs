namespace Api.MovimientosLlantas.Controllers
{
    using Core.MovimientosLlantas.Dto;
    using Core.MovimientosLlantas.Interface;
    using Core.MovimientosLlantas.Servicios;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    /// <summary>
    /// Controlador encargado de gestionar las peticiones HTTP relacionadas con las llantas.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LlantasController : ControllerBase
    {
        // Regla SA1313: Variable privada con _camelCase
        private readonly IServiceUnitOfWork _serviceUnitOfWork;

        /// <summary>
        /// Inicializa una nueva instancia del controlador inyectando las dependencias permitidas.
        /// </summary>
        /// <param name="serviceUnitOfWork">La unidad de trabajo que contiene los servicios de negocio.</param>
        public LlantasController(IServiceUnitOfWork serviceUnitOfWork)
        {
            // Regla ML2008: Solo inyectamos IServiceUnitOfWork (y otras pocas permitidas). 
            // ¡Nunca inyectamos LlantasService directamente!
            _serviceUnitOfWork = serviceUnitOfWork;
        }

        /// <summary>
        /// Registra una nueva llanta en el sistema desde una petición externa.
        /// </summary>
        /// <param name="llantaDto">Los datos de la llanta a registrar.</param>
        /// <returns>Un código de estado HTTP 200 si fue exitoso.</returns>
        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar(RegistroLlantaDto llantaDto)
        {
            // Regla ML1005: Endpoints máximo 4 líneas. Toda la lógica se delega.
            await _serviceUnitOfWork.LlantasService.RegistrarLlanta(llantaDto);

            return Ok(); // Responde con un HTTP 200 (Todo bien)
        }
    }
}