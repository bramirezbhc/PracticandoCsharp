using PracticandoCsharp.App;
using PracticandoCsharp.Entidades;
using PracticandoCsharp.Util;
using System;
using System.Collections.Generic;
using static System.Console;

namespace PracticandoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("Bienvenido a la Escuela");
            Printer.Beep(3000, cantidad:20);
            ImprimirCursosEscuela(engine.Escuela);
            Console.ReadLine();
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela");
            foreach (var curso in escuela.Cursos)
            {
                WriteLine(curso);
                WriteLine();
            }
        }
    }
}
