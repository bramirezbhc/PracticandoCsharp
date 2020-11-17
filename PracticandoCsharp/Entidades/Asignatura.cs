using System;
using System.Collections.Generic;
using System.Text;

namespace PracticandoCsharp.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();
    }
}
