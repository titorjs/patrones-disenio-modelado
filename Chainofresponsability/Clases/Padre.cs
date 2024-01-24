namespace ChainofresponsabilityEj.Clases
{
    public class Padre : AprovacionBase
    {
        public Padre()
        {
            Limite = 50;
        }
        public override string SolicitudPermiso(Solicitud solicitudPermiso)
        {
            if (solicitudPermiso.Nivel <= Limite)
            {
                return("Claro Hijito");
            }
            else if (Proximo != null)
            {
                return Proximo.SolicitudPermiso(solicitudPermiso);
            }
            else
            {
                return("Preguntale a tu Madre");
            }
            
        }
    }
}
