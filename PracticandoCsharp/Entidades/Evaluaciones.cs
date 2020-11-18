using System;
using System.Collections.Generic;
using System.Text;

namespace PracticandoCsharp.Entidades
{
    public class Evaluaciones
    {
        //Propiedades
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        //Constructor
        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}
