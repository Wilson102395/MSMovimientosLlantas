namespace Core.MovimientosLlantas.Dto
{
    ///<summary>
    ///Objeto de trasnferencia para registrar una nueva llanta al sistema.
    ///</summary>
    public class ResgistroLlantaDto
    {
        ///<summary>
        ///La marca de la llanta ingresada por el usuario.
        ///</summary>
        public string Marca { get; set; } = string.Empty;

        ///<summary>
        ///El kilometraje inicial, generalmente cero al registrar
        ///</summary>
        public int KilometrajeInicial {  get; set; }
    }
}
