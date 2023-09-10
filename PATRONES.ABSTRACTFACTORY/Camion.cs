namespace PATRONES.ABSTRACTFACTORY
{
    public abstract class Camion
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