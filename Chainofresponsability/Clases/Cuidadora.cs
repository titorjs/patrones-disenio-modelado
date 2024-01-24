namespace ChainofresponsabilityEj.Clases
{
    public class Cuidadora : AprovacionBase
    {
        public Cuidadora()
        {
            Limite = 20;
        }

        public override string SolicitudPermiso(Solicitud solicitudPermiso)
        {
            if (solicitudPermiso.Nivel <= Limite)
            {
                return("Permiso Concedido Por la Niñera");
            }else if (Proximo != null)
            {
                return Proximo.SolicitudPermiso(solicitudPermiso);
            }
            else
            {
                return("Preguntale a tus padres");
            }
            
        }
    }
}
