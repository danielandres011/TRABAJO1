using System.Collections.Generic;
using System.Threading;

namespace PATRONES.BUILDER
{
    public abstract class CarroceriaBuilder
    {
        protected string _descripcion;
        public abstract void reset();
        public abstract Vidrios buildVidrios();
        public override string ToString()
        {
            return _descripcion;
        }

        public Carroceria BuildCarroceria()
        {
            Vidrios vidrios = buildVidrios();
            return new Carroceria(vidrios, _descripcion);
        }

    }
}