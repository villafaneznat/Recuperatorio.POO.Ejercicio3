using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.POO.Ejercicio3.Entidades
{
    public static class Horoscopo
    {
        public static string SignoZodiacal(DateTime fechaNac)
        {
            var mes = fechaNac.Month;
            var dia = fechaNac.Day;
            string signo = "";

            if (mes == 12 && dia >= 22)
            {
                signo = "capricornio";
            }
            if (dia <= 20 && mes == 01)
            {
                signo = "capricornio";
            }

            if (mes == 01 && dia >= 21)
            {
                signo = "acuario";
            }
            if (dia <= 19 && mes == 02)
            {
                signo = "acuario";
            }

            if (dia >= 20 && mes == 02)
            {
                signo = "piscis";
            }
            if (dia <= 20 && mes == 03)
            {
                signo = "piscis";
            }

            if (dia >= 21 && mes == 03)
            {
                signo = "aries";
            }
            if (dia <= 20 && mes == 04)
            {
                signo = "aries";
            }

            if (dia >= 21 && mes == 04)
            {
                signo = "tauro";
            }
            if (dia <= 21 && mes == 05)
            {
                signo = "tauro";
            }

            if (dia >= 22 && mes == 05)
            {
                signo = "geminis";
            }
            if (dia <= 21 && mes == 06)
            {
                signo = "geminis";
            }

            if (dia >= 22 && mes == 06)
            {
                signo = "cancer";
            }
            if (dia <= 22 && mes == 07)
            {
                signo = "cancer";
            }

            if (dia >= 23 && mes == 07)
            {
                signo = "leo";
            }
            if (dia <= 22 && mes == 08)
            {
                signo = "leo";
            }

            if (dia >= 23 && mes == 08)
            {
                signo = "virgo";
            }
            if (dia <= 22 && mes == 09)
            {
                signo = "virgo";
            }

            if (dia >= 23 && mes == 09)
            {
                signo = "libra";
            }
            if (dia <= 22 && mes == 10)
            {
                signo = "libra";
            }

            if (dia >= 23 && mes == 10)
            {
                signo = "escorpio";
            }
            if (dia <= 22 && mes == 11)
            {
                signo = "escorpio";
            }

            if (dia >= 23 && mes == 11)
            {
                signo = "sagitario";
            }
            if (dia <= 21 && mes == 12)
            {
                signo = "sagitario";
            }

            return signo;
        }
        public static string SignoChino(int anio)
        {
            string signo = "";
            if (anio % 12 == 0)
            {
                signo = "mono";
            }
            if (anio % 12 == 1)
            {
                signo = "gallo";
            }
            if (anio % 12 == 2)
            {
                signo = "perro";
            }
            if (anio % 12 == 3)
            {
                signo = "cerdo";
            }
            if (anio % 12 == 4)
            {
                signo = "rata";
            }
            if (anio % 12 == 5)
            {
                signo = "buey";
            }
            if (anio % 12 == 6)
            {
                signo = "tigre";
            }
            if (anio % 12 == 7)
            {
                signo = "conejo";
            }
            if (anio % 12 == 8)
            {
                signo = "dragon";
            }
            if (anio % 12 == 9)
            {
                signo = "serpiente";
            }
            if (anio % 12 == 10)
            {
                signo = "caballo";
            }
            if (anio % 12 == 11)
            {
                signo = "cabra";
            }
            return signo;
        }
    }
}
