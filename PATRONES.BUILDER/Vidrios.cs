namespace PATRONES.BUILDER
{
    public abstract class Vidrios
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }

    }

    public class VidriosOscuros : Vidrios
    {
        public VidriosOscuros()
        {
            _descripcion = "Vidrios oscuros";
        }
    }

    public class VidriosTransparentes : Vidrios
    {
        public VidriosTransparentes()
        {
            _descripcion = "vidrios transparentes";
        }
    }

}