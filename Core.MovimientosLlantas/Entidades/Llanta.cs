namespace Core.MovimientosLlantas.Entidades
{
    /// <summary>
    /// Represneta una llanta dentro del inventario fisico.
    /// </summary>
    public class Llanta
    {
        ///<value>
        ///El iddentificador unico de la llanta.
        /// </value>
        public int LlantaId {  get; set; }

        ///<value>
        ///La marca comercial de la llanta.
        ///</value>
        public string Marca { get; set; } = string.Empty;

        ///<value>
        ///El kilometraje actual recorrido por la llanta.
        ///</value>
        public int KilometrajeActual { get; set; }
     }
}

