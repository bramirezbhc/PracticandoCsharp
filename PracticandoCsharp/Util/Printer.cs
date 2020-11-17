using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PracticandoCsharp.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 10)
        {
            WriteLine("".PadLeft(tamaño, '='));
        }

        public static void WriteTitle(string title)
        {
            var tamaño = title.Length + 4; 
            DibujarLinea(tamaño);
            WriteLine($"| {title} |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int hz=2000, int tiempo=500, int cantidad=1)
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}
