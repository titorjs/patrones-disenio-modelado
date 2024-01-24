namespace ChainofresponsabilityEj.Clases
{
    public abstract class AprovacionBase : IAprovacion
    {
        protected int Limite;
        protected IAprovacion Proximo;
        public void ProximoAprovador(IAprovacion proximo)
        {
            Proximo = proximo;
        }
        public abstract string SolicitudPermiso(Solicitud solicitudPermiso);
    }
}
