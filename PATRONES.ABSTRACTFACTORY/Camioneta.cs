namespace PATRONES.ABSTRACTFACTORY
{
    public abstract class Camioneta
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