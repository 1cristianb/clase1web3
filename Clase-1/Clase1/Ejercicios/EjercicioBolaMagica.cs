using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioBolaMagica
    {
        public static void Jugar()
        {
            List<String> lista = new List<String>();
            Random rnd = new Random();

            lista.Add("Sin lugar a dudas.");
            lista.Add("Como yo lo veo, sí.");
            lista.Add(" Mejor no decirte ahora.");
            lista.Add("Vuelve a preguntar más tarde");
            lista.Add("Respuesta confusa, vuelve a intentarlo.");
            lista.Add("Mi respuesta es no.");
            lista.Add("Muy dudoso.");
            lista.Add("Las perspectivas no son muy buenas");

            int randIndex = rnd.Next(lista.Count);
            String random = lista[randIndex];

            Console.WriteLine("Ingrese su pregunta (del tipo Si/No):");
            string linea1 = Console.ReadLine();

            Console.WriteLine(random);
        }
    }
}
