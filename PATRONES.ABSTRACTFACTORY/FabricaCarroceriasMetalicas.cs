namespace PATRONES.ABSTRACTFACTORY
{
    public class FabricaCarroceriasMetalicas : FabricaCarrocerias
    {
        public override Camion CrearCamion()
        {
            return new CamionMetalicas();
        }

        public override Camioneta CrearCamioneta()
        {
            return new CamionetaMetalicas();
        }

        public override Furgon CrearFurgon()
        {
            return new FurgonMetalicas();
        }
    }
}