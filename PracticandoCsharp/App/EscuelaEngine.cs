using System;
using System.Collections.Generic;
using System.Text;
using PracticandoCsharp.Entidades;

namespace PracticandoCsharp.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Canada", 2015, TiposEscuela.Secundaria, "Honduras", "Tegucigalpa");

            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){
                    Nombre = "Java",
                    Jornada = TiposJornada.tarde,
                },
                new Curso(){
                    Nombre = "Php",
                    Jornada = TiposJornada.noche,
                },
                new Curso(){
                    Nombre = "C#",
                    Jornada = TiposJornada.tarde,
                },
                new Curso() {
                    Nombre = "Visual Basic .Net",
                    Jornada=TiposJornada.tarde
                },
                new Curso() {
                    Nombre = "C++",
                    Jornada = TiposJornada.noche

                }
            };
        }
    }
}
