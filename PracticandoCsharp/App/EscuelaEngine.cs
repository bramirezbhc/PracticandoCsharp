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

            CargarCursos();
            CargarAsignaturas();
            CargarAlumnos();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                   new Asignatura(){
                    Nombre = "Matematicas"
                   },
                   new Asignatura()
                   {
                       Nombre = "Educacion FIsica"
                   },
                   new Asignatura()
                   {
                       Nombre = "Castellano"
                   },
                   new Asignatura()
                   {
                       Nombre = "Ciencias Naturales"
                   }
                };

                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarAlumnos()
        {
            string[] nombre1 = { "ALBA", "FELIPA", "EUSEBIO", "FARID", "DONALD", "ALVARO", "NICOLAS"};
            string[] apelllido1 = { "RUIZ", "SARMIENTO", "URIBE", "MADURO", "TRUMP", "TOLEDO", "HERRERA" };
            string[] nombre2 = {"FREDY",  "ANABEL", "RICK", "MURTY", "SILVANA", "DIOMEDES", "NICOMEDES", "TEODORO"};

            var listaAlumnos = 

        }

        private void CargarCursos()
        {
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
