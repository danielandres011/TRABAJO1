using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRONES.PROTOTYPE
{
    public class Program
    {
        public abstract class CamionetaPrototype
        {
            protected string _color;
            protected string _modelo;

            public string setColor
            {
                set => _color = value;
            }
            public string setModelo
            {
                set => _modelo = value;
            }

            public abstract CamionetaPrototype Clonar();
            public abstract string VerCamioneta();
        }

        public class FordPrototype : CamionetaPrototype
        {
            public override CamionetaPrototype Clonar()
            {
                return (FordPrototype)this.MemberwiseClone();
            }

            public override string VerCamioneta()
            {
                return $"Ford {_modelo} color  {_color}";
            }
        }

        public class ChevroletPrototype : CamionetaPrototype
        {
            public override CamionetaPrototype Clonar()
            {
                return (ChevroletPrototype)this.MemberwiseClone();
            }

            public override string VerCamioneta()
            {
                return $"Chevrolet {_modelo} color  {_color}";
            }
        }

        static void Main(string[] args)
        {
            CamionetaPrototype fordPrototype = new FordPrototype();
            fordPrototype.setModelo = "2023";
            fordPrototype.setColor = "Rojo";

            CamionetaPrototype chevroletPrototype = new ChevroletPrototype();
            chevroletPrototype.setModelo = "2000";
            chevroletPrototype.setColor = "Azul";

            Console.WriteLine("-- Inicio --");
            Console.WriteLine(fordPrototype.VerCamioneta());
            Console.WriteLine(chevroletPrototype.VerCamioneta());
            Console.WriteLine("-- Despues --");
            CamionetaPrototype fordPrototype2 = fordPrototype.Clonar();
            Console.WriteLine(fordPrototype.VerCamioneta());
            Console.WriteLine(fordPrototype2.VerCamioneta());
            Console.WriteLine("-- Modificado --");
            fordPrototype.setModelo = "2010";
            Console.WriteLine(fordPrototype.VerCamioneta());
            Console.WriteLine(fordPrototype2.VerCamioneta());
            Console.ReadLine();
        }
    }
}
