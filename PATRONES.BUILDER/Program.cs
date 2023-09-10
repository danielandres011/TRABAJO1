using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRONES.BUILDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CarroceriaBuilder> opciones = new List<CarroceriaBuilder>();
            opciones.Add(new CarroceriaMetalicaBuilder());
            opciones.Add(new CarroceriaEstacasBuilder());
            Console.WriteLine("-- carroceria a elegir --"); 
            Console.WriteLine("Carroceria metalica: 1");
            Console.WriteLine("Carroceria estacas: 2");
            int valor = int.Parse(Console.ReadLine());
            CarroceriaBuilder carroceriaBuilder;
            if (valor == 1)
            {
                carroceriaBuilder = opciones.FirstOrDefault();
                carroceriaBuilder.BuildCarroceria();
            }
            else
            {
                carroceriaBuilder = opciones.LastOrDefault();
                carroceriaBuilder.BuildCarroceria();
            }
            Console.WriteLine("-- carroceria elegida --");
            Console.WriteLine(carroceriaBuilder.ToString());
            Console.ReadLine();
        }
    }
}
