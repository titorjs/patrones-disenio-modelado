namespace ChainofresponsabilityEj.Clases
{
    public class Madre : AprovacionBase
    {
        public Madre()
        {
            Limite = 100;
        }
        public override string SolicitudPermiso(Solicitud solicitudPermiso)
        {
            if (solicitudPermiso.Nivel <= Limite)
            {
                return("Vaya Mijito");
            }
            else if (Proximo != null)
            {
                return Proximo.SolicitudPermiso(solicitudPermiso);
            }
            else
            {
                return("Preguntale a tu Padre");
            }
            
        }
    }
}
