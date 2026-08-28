namespace Core.MovimientosLlantas.Interface
{
    using Core.MovimientosLlantas.Dto;
    using Core.MovimientosLlantas.Servicios;
    using System.Threading.Tasks;

    public interface ILlantasService
    {
        Task RegistrarLlanta(RegistroLlantaDto llantaDto);
    }
}