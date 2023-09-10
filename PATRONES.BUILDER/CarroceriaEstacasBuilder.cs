namespace PATRONES.BUILDER
{
    public class CarroceriaEstacasBuilder : CarroceriaBuilder
    {
        public CarroceriaEstacasBuilder()
        {
            _descripcion = "Carroceria estacas";
        }
        public override Vidrios buildVidrios()
        {
            return new VidriosTransparentes();
        }

        public override void reset()
        {
            throw new System.NotImplementedException();
        }
    }
}