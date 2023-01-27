using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();

            //c1.Color = "Amarillo";
            //c2.Color = "Rojo";
            //c3.Color = "Blanco";

            //List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c1);
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La Cantidad de camionetas es: " + listaCamionetas.Count);
            //Console.WriteLine(listaCamionetas[2].Color);
            //Console.WriteLine(listaCamionetas[2].GetHashCode());
            //Console.WriteLine(listaCamionetas[1].GetHashCode());
            //Console.WriteLine(listaCamionetas[0].GetHashCode());
            //Console.WriteLine("Defina Color de la camioneta 2: ");
            //c2.Color = Console.ReadLine();
            //Console.WriteLine("El color de la camioneta 2 es: ");
            //Console.WriteLine(listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La Cantidad de camionetas es: " + listaCamionetas.Count);
            //Console.WriteLine(c1.GetType());

            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine(item.Color);
            //}

            Chasis ch1 = new Chasis();
            ch1.Color = "azul";
            Auto a1 = new Auto();
            a1.Chasis.Color = "Rojo";
            a1.Motor = new Motor();
            a1.Motor.Marca = "Toyota";
            Console.WriteLine(a1.Motor.Marca);
            Console.WriteLine(a1.Chasis.Color);
            a1.Chasis = ch1;
            Console.WriteLine(a1.Chasis.Color);






            Console.ReadKey();



        }
    }
}
