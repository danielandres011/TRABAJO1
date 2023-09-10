namespace PATRONES.ABSTRACTFACTORY
{
    public abstract class FabricaCarrocerias
    {
        public abstract Camioneta CrearCamioneta();
        public abstract Camion CrearCamion();
        public abstract Furgon CrearFurgon();
    }
}