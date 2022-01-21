using System;

namespace Patrón_Singleton_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //obtenemos la instancia, se crea por primera vez 
            Singleton persona = Singleton.ObtenerInstancia();

            //Hacemos algo con la instancia
            persona.AgregarDatos("Erick",20);
            persona.proceso();
            Console.WriteLine(persona);
            Console.WriteLine("-------------------------------------------\n");
            //obtenemos la instancia 
            Singleton persona2 = Singleton.ObtenerInstancia();

            //comprobamos que es la misma instancia
            //si lo es, tendrá el mismo estado
            Console.WriteLine(persona2);
        }
    }
}
