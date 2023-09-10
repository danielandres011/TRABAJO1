namespace PATRONES.BUILDER
{
    public class CarroceriaMetalicaBuilder : CarroceriaBuilder
    {
        public CarroceriaMetalicaBuilder()
        {
            _descripcion = "Carroceria metalica";
        }
        public override Vidrios buildVidrios()
        {
            return new VidriosOscuros();
        }

        public override void reset()
        {
            throw new System.NotImplementedException();
        }
    }
}