using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalesDomesticos a1 = new AnimalesDomesticos();
            Animal p1= new Perro();
            Gato g1= new Gato();
            Canario c1 = new Canario();
            g1.Nombre = "Saroo";
            a1.Nombre = "pepe";
            c1.Nombre = "Piolin";
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.Comunicarse());
            Console.WriteLine(p1.Comunicarse());
            Console.WriteLine("El gato dice: " + g1.Comunicarse());
            Console.WriteLine(c1.Nombre + " dice " + c1.Comunicarse());

            
            Animal a2 = g1;
            Gato g8 = (Gato)a2;
            Console.WriteLine("Prueba de variable tipo animal: " + a2.Comunicarse());

            List<Animal> list = new List<Animal>();
            list.Add(a1);
            list.Add(p1);
            list.Add(g1);
            list.Add(c1);
            list.Add(new Aguila());
            list.Add(a2);
            

            List<IVolador> voladores= new List<IVolador>();
            voladores.Add(c1);
            voladores.Add((Aguila)list[4]);

            foreach (Animal item in voladores)
            {
                Console.WriteLine(item.Comunicarse()); 
            }
            

            //foreach (Animal item in list)
            //{

            //    Console.WriteLine(item.Comunicarse());

            //}

            //Console.WriteLine("Prueba de animal cargado en lista: " + list[4].Comunicarse());

            Console.ReadLine();
        }
    }
}
