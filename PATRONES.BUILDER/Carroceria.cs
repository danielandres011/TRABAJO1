namespace PATRONES.BUILDER
{
    public class Carroceria
    {
        string _tipo;
        Vidrios _vidrios;

        public override string ToString()
        {
            return $"{_tipo}, Vidrios: {_vidrios.Descripcion}";
        }


        public Carroceria(Vidrios vidrios, string tipo)
        {
            _vidrios = vidrios;
            _tipo = tipo;
        }

    }
}