namespace PATRONES.ABSTRACTFACTORY
{
    public class FabricaCarroceriasEstacas : FabricaCarrocerias
    {
        public override Camion CrearCamion()
        {
            return new CamionEstacas();
        }

        public override Camioneta CrearCamioneta()
        {
            return new CamionetaEstacas();
        }

        public override Furgon CrearFurgon()
        {
            return new FurgonEstacas();
        }
    }
}