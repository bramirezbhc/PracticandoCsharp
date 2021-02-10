using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PracticandoCsharp.Entidades;

namespace PracticandoCsharp.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public Curso Curso { get; set; }

        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Canada", 2015, TiposEscuela.Secundaria, "Honduras", "Tegucigalpa");

            CargarCursos();
            CargarAsignaturas();

            //foreach (var curso in Escuela.Cursos)
            //{
            //    curso.Alumnos.AddRange(CargarAlumnos());
            //}
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            
            
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                   new Asignatura(){
                    Nombre = "Matematicas",
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

                curso.Asignaturas = listaAsignaturas;


            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "ALBA", "FELIPA", "EUSEBIO", "FARID", "DONALD", "ALVARO", "NICOLAS"};
            string[] apelllido1 = { "RUIZ", "SARMIENTO", "URIBE", "MADURO", "TRUMP", "TOLEDO", "HERRERA" };
            string[] nombre2 = {"FREDY",  "ANABEL", "RICK", "MURTY", "SILVANA", "DIOMEDES", "NICOMEDES", "TEODORO"};

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apelllido1
                               select new Alumno() { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy(al => al.UniqueId).Take(cantidad).ToList();
        }

        private List<Evaluaciones> GenerarEvaluaciones(int cantidad)
        {
            string[] evaluaciones = { "EXAMEN", "PRUEBA", "TAREA 1", "TAREA 2", "TAREA 3", "TAREAS 4", "PRUEBA EXAMEN", "EXPOSICION", "QUIZ"};

            var listaEvaluaciones = from eval in evaluaciones
                                    select new Evaluaciones() { Nombre = eval };

            return listaEvaluaciones.OrderBy(ev => ev.UniqueId).Take(cantidad).ToList();
        }

        private List<Evaluaciones> GenerarEvaluacionesAlAzar()
        {


            return null;
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

            Random rnd = new Random();

            foreach (var curso in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }

        }
    }
}
