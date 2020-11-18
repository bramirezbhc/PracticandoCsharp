using System;
using System.Collections.Generic;
using System.Text;

namespace PracticandoCsharp.Entidades
{
    public class Alumno
    {
        //Propiedades
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        //Constructor
        public Alumno() => UniqueId = Guid.NewGuid().ToString();
    }
}
