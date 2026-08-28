namespace Core.MovimientosLlantas.Servicios
{
    using System.Threading.Tasks;
    using Core.MovimientosLlantas.Dto;
    using Core.MovimientosLlantas.Interface;

    public class LlantasService : ILlantasService
    {
        // Solo dejamos este método. Revisa que el nombre sea idéntico al de la interfaz.
        public async Task RegistrarLlanta(RegistroLlantaDto llantaDto)
        {
            // Simulamos que hace el trabajo
            await Task.CompletedTask;
        }
    }
}