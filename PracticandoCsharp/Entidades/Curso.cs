using System;
using System.Collections.Generic;
using System.Text;

namespace PracticandoCsharp.Entidades
{
    public class Curso
    {
        //Propiedades
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

        //Constructor
        public Curso() => UniqueId = Guid.NewGuid().ToString();

        //Metodo override ToString()
        public override string ToString()
        {
            return $"Id: {UniqueId} \nNombre: {Nombre} \nJornada: {Jornada}";
        }
    }
}
