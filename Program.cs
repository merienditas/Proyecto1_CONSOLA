using System;

namespace Proyecto_1._consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cual es tu primer color favorito");
            string usuario;
            usuario = Console.ReadLine(); // respuesta del usuario (para guardarlo, has de coger la variable IGUAL A readline)
            Console.WriteLine ("Has elegido el color " + usuario); 

            Console.WriteLine ("¿Cuál es color favorito de tu prima?");
            string usuario1;
            usuario1 = Console.ReadLine();
            Console.WriteLine("El color elegido es " + usuario1 );

            string.Equals(usuario, usuario1); // hacer comparaciones
            
            bool resultado = (string.Equals(usuario,usuario1)); // preguntas cerradas de SioNo//VoF
            Console.WriteLine(resultado);
            Console.ReadLine();
            


            


        }
    }
}


    
