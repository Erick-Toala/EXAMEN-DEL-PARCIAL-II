using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_Singleton_Examen
{
    class Singleton
    {
        //Aqui guardamos la unica instancia que va a existir 
        private static Singleton instancia;

        //Datos propios de la clase que pertenecen a una persona
        private string nombre;
        private int edad;

        //creamos un constructor privado
        private Singleton()
        {
            nombre = "Sin asignar";
            edad = 0;
        }
        public static Singleton ObtenerInstancia()
        {
            //verificamos si no existe la instancia 
            if (instancia == null)
            {
                //si no existe, instanciamos
                instancia = new Singleton();
                Console.WriteLine("---- Instancia creada por primera vez -----");
            }
            //regresamos la instancia
            return instancia;
        }
        //aquí metodos propios de la clase 
        public override string ToString()
        {
            return string.Format("La persona "+nombre+", tiene una edad de "+edad+" años");
        }
        public void AgregarDatos(string nombre1, int edad1)
        {
            nombre = nombre1;
            edad = edad1;
        }
        //esto representa cualquier otro objeto 
        public void proceso()
        {
            Console.WriteLine(nombre+" está trabajando");   
        }
    }
}
