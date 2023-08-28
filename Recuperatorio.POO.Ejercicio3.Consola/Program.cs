using Recuperatorio.POO.Ejercicio3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.POO.Ejercicio3.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fecha = new DateTime(2001,11,17);
            var signoZodiacal = Horoscopo.SignoZodiacal(fecha);
            var signoChino = Horoscopo.SignoChino(2001);
            Console.WriteLine(signoZodiacal);
            Console.WriteLine(signoChino);

            Console.ReadLine();
        }
    }
}
