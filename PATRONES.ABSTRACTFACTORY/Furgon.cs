namespace PATRONES.ABSTRACTFACTORY
{
    public abstract class Furgon
    {
        protected string _descripcion;

        public object Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
    }
}