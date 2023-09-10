using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PATRONES.ABSTRACTFACTORY
{
    public class Program
    {
        static void Main(string[] args)
        {

            FabricaCarrocerias f;
            f = new  FabricaCarroceriasEstacas();
            Camioneta camioneta = f.CrearCamioneta();
            Camion camion = f.CrearCamion();
            Furgon furgon = f.CrearFurgon();
            Console.WriteLine($"Camioneta: {camioneta.Descripcion}, Camion: {camion.Descripcion}, Furgon: {furgon.Descripcion} ");

            f = new FabricaCarroceriasMetalicas();
            camioneta = f.CrearCamioneta();
            camion = f.CrearCamion();
            furgon = f.CrearFurgon();
            Console.WriteLine($"Camioneta: {camioneta.Descripcion}, Camion: {camion.Descripcion}, Furgon: {furgon.Descripcion} ");
            Console.ReadLine();
        }
    }
}
